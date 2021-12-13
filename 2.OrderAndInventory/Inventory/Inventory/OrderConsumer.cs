using MassTransit;
using Model;
using System;
using System.Threading.Tasks;

namespace Inventory
{
    internal class OrderConsumer : IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
        }
    }
}