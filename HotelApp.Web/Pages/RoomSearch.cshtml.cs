using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelAppLibrary.Data;
using HotelAppLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelApp.Web.Pages
{
    public class RoomSearchModel : PageModel
    {
        private readonly IDatabaseData _db;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime startDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime endDate { get; set; } = DateTime.Now.AddDays(1);

        [BindProperty(SupportsGet = true)]
        public bool SearchEnabled { get; set; }=false;
        public List<RoomTypeModel> AvailableRoomTypes { get; set; }

        public RoomSearchModel(IDatabaseData db)
        {
            _db = db;
        }

        public void OnGet()
        {
            if (SearchEnabled == true)
            {
               AvailableRoomTypes = _db.GetAvailableRoomTypes(startDate, endDate);
            }
        }



        public IActionResult OnPost()
        {

            return RedirectToPage(new
            {
                SearchEnabled=true,
                startDate=startDate.ToString("yyyy-MM-dd"),
                endDate= endDate.ToString("yyyy-MM-dd")
            });
        }
    }
}
