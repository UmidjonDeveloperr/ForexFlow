//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

namespace ForexFlow.Api.Models.Foundations.Balances
{
	public class Balance
	{
        public Guid Id { get; set; }
        public decimal USD { get; set; }
        public decimal UZS { get; set; }
        public decimal RUB { get; set; }
        public Guid UserId { get; set; }
    }
}
