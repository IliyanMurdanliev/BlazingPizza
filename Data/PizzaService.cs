namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            return Task.Run(() => new Pizza[] { 
                new Pizza() { PizzaId = 1, Name = "Margharitta", Price = 10 },
                new Pizza() { PizzaId = 2, Name = "Hawaiian", Price = 14 },
                new Pizza() { PizzaId = 3, Name = "Fiorentina", Price = 15 },
            });
            // Call your data access technology here
        }
    }
}
