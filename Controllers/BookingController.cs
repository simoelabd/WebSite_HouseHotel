using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Webhotel.Models;
using Webhotel.Services;

namespace Webhotel.Controllers
{
    public class BookingController : Controller
    {
        private readonly DatabaseConnection _dbConnection;

        public BookingController(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                using (var connection = _dbConnection.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                            INSERT INTO webbookings (fullname, phonenumber, emailaddress, days, numofadults)
                            VALUES (@FullName, @PhoneNumber, @EmailAddress, @Days, @NumOfAdults)";

                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FullName", booking.FullName);
                            command.Parameters.AddWithValue("@PhoneNumber", booking.PhoneNumber);
                            command.Parameters.AddWithValue("@EmailAddress", booking.EmailAddress);
                            command.Parameters.AddWithValue("@Days", booking.Days);
                            command.Parameters.AddWithValue("@NumOfAdults", booking.NumOfAdults);

                            command.ExecuteNonQuery();
                        }

                        ViewBag.Message = "Booking successfully saved!";
                        return View("/Views/Home/Index.cshtml");
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = "An error occurred: " + ex.Message;
                    }
                }
            }

            return View("/Views/Home/Index.cshtml");
        }
    }
}
