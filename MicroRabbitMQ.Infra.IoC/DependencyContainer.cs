﻿using MediatR;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
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

namespace MicroRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            // Domain Bus
            // services.AddTransient<IEventBus, RabbitMQBus>();  before bus refactory
            services.AddSingleton<IEventBus, RabbitMQBus>(sp => 
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // Services   Make it available for our subscription list
            services.AddTransient<TransferEventHandler>();

            // Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();           

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // Data
            services.AddTransient<IAccountRepository, AccoutRepository>();
            services.AddTransient<ITransferRepository, TransferRepositiry>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

        }
    }
}
