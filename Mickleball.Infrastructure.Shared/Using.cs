﻿global using AutoBogus;
global using Bogus;
global using Bogus.DataSets;
global using MailKit.Net.Smtp;
global using MailKit.Security;
global using Mickleball.Application.DTOs.Email;
global using Mickleball.Application.Exceptions;
global using Mickleball.Application.Interfaces;
global using Mickleball.Domain.Entities;
global using Mickleball.Domain.Enums;
global using Mickleball.Domain.Settings;
global using Mickleball.Infrastructure.Shared.Mock;
global using Mickleball.Infrastructure.Shared.Services;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using MimeKit;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading.Tasks;