using Microsoft.EntityFrameworkCore;

namespace EfWorkshopDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the Student database by running the CreateAndSeedDB.sql script

            // install the following Nuget-packages:
            //  Microsoft.EntityFrameworkCore - 8.0.8
            //  Microsoft.EntityFrameworkCore.SqlServer - 8.0.8
            //  Microsoft.EntityFrameworkCore.Tools - 8.0.8
            //  Microsoft.EntityFrameworkCore.Design - 8.0.8

            // use EF CLI tools to scaffold conceptual models by reverse engineering the existing database tables
            //  install the dotnet EF CLI toolset with Package Manager Console: dotnet tool install --global dotnet-ef --version 8.0.8
            //  scaffold conceptual models:
            //      dotnet ef dbcontext scaffold "Server=localhost;Database=University;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameWorkCore.SqlServer -o "Models"

        }
    }
}
