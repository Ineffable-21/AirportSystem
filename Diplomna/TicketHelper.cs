using Diplomna.DBWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna
{
    internal class TicketHelper(TicketSoldWork ticketSoldWork, PlaneWork planeWork)
    {
        private readonly TicketSoldWork _ticketSoldWork = ticketSoldWork;
        private readonly PlaneWork _planeWork = planeWork;

        public decimal? GetBasePrice(int flightId, string ticketClass)
        {
            Models.Plane selectedPlane = _ticketSoldWork.GetPlaneByFlightId(flightId);
            if (selectedPlane == null) return null;

            decimal? basePrice;

            switch (ticketClass)
            {
                case "Икономическа":
                    basePrice = selectedPlane.EconomyTicketsPrice;
                    break;
                case "Бизнес":
                    basePrice = selectedPlane.BusinessTicketsPrice;
                    break;
                case "Първа":
                    basePrice = selectedPlane.FirstClassTicketsPrice;
                    break;
                default:
                    return null; 
            }

            return basePrice;
        }

        #pragma warning disable CA1822 // Mark members as static
        public bool ValidateTicketInput(int clientId, int flightId, string ticketClass, string ticketNumText, out int ticketsNum, out string errorMessage)
        #pragma warning restore CA1822 // Mark members as static
        {
            ticketsNum = 0;

            if (clientId == 0 || flightId == 0)
            {
                errorMessage = "Моля изберете клиент и полет.";
                return false;
            }

            if (!int.TryParse(ticketNumText, out ticketsNum) || ticketsNum <= 0)
            {
                errorMessage = "Моля въведете валиден брой билети.";
                return false;
            }

            if (string.IsNullOrEmpty(ticketClass))
            {
                errorMessage = "Моля изберете клас.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        #pragma warning disable CA1822 // Mark members as static
        public decimal? CalculateFinalPrice(decimal? basePrice, int ticketsNum)
        #pragma warning restore CA1822 // Mark members as static
        {
            return basePrice * ticketsNum;
        }

        public bool CheckAvailableTickets(int flightId, string ticketClass, int ticketsNum, out string errorMessage)
        {
            Models.Plane selectedPlane = _ticketSoldWork.GetPlaneByFlightId(flightId);

            if (selectedPlane == null)
            {
                errorMessage = "Няма наличен самолет за този полет.";
                return false;
            }

            switch (ticketClass)
            {
                case "Икономическа":
                    if (selectedPlane.EconomyTicketsCount.HasValue && selectedPlane.EconomyTicketsCount.Value < ticketsNum)
                    {
                        errorMessage = "Няма достатъчно налични икономически билети.";
                        return false;
                    }
                    break;

                case "Бизнес":
                    if (selectedPlane.BusinessTicketsCount.HasValue && selectedPlane.BusinessTicketsCount.Value < ticketsNum)
                    {
                        errorMessage = "Няма достатъчно налични бизнес билети.";
                        return false;
                    }
                    break;

                case "Първа":
                    if (selectedPlane.FirstClassTicketsCount.HasValue && selectedPlane.FirstClassTicketsCount.Value < ticketsNum)
                    {
                        errorMessage = "Няма достатъчно налични билети за първа класа.";
                        return false;
                    }
                    break;

                default:
                    errorMessage = "Невалиден клас на билета.";
                    return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public void UpdateTicketCounts(int flightId, string ticketClass, int ticketsNum, bool ticketSold)
        {
            Models.Plane selectedPlane = _ticketSoldWork.GetPlaneByFlightId(flightId);

            if (selectedPlane == null) return;

            switch (ticketClass)
            {
                case "Икономическа":
                    if (selectedPlane.EconomyTicketsCount.HasValue)
                    {
                        if (ticketSold)
                            selectedPlane.EconomyTicketsCount -= ticketsNum;
                        else
                            selectedPlane.EconomyTicketsCount += ticketsNum;
                    }
                    break;

                case "Бизнес":
                    if (selectedPlane.BusinessTicketsCount.HasValue)
                    {
                        if (ticketSold)
                            selectedPlane.BusinessTicketsCount -= ticketsNum;
                        else
                            selectedPlane.BusinessTicketsCount += ticketsNum;
                    }
                    break;

                case "Първа":
                    if (selectedPlane.FirstClassTicketsCount.HasValue)
                    {
                        if (ticketSold)
                            selectedPlane.FirstClassTicketsCount -= ticketsNum;
                        else
                            selectedPlane.FirstClassTicketsCount += ticketsNum;
                    }
                    break;
            }

            selectedPlane.TotalSpaces -= ticketSold ? ticketsNum : -ticketsNum;

            _planeWork.UpdatePlane(selectedPlane);
        }
    }
}
