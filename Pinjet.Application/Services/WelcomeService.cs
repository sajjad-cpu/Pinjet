using Pinjet.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinjet.Application.Services
{
    public class WelcomeService : IWelcomeService
    {
        public string GetMessage()
        {
            return "Welcome to Pinjet!";
        }
    }
}
