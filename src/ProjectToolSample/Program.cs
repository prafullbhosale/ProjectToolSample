using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.DotNet.Cli.Utils;

namespace ProjectToolSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Command.Create("dotnet-inside-man", args, NuGet.Frameworks.FrameworkConstants.CommonFrameworks.NetCoreApp10)
                .ForwardStdErr()
                .ForwardStdOut()
                .Execute();
        }
    }
}
