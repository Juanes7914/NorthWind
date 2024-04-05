﻿namespace NorthWind.Core.Services
{
    internal class ProductService(IUserActionWriter writer) : IProductService
    {
        public void Add(string user, string productName)
        {
            UserAction Action = new UserAction(user, $"Created: {productName}");
            writer.Write(Action);
        }
    }
}