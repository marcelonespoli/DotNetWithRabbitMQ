using MediatR;
using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Services;
using MicroRabbitMQ.Banking.Data.Context;
using MicroRabbitMQ.Banking.Data.Repository;
using MicroRabbitMQ.Banking.Domain.CommandHandlers;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.Interfaces;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();

            // Data
            services.AddTransient<IAccountRepository, AccoutRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
