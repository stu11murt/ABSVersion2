using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ABSDAL;

namespace ABSCore1.Models
{
    public class NewBookingModel
    {

        #region "Core Booking"

        public string officeRef { get; set; }

        public string groupOrganiser { get; set; }

        public string partyName { get; set; }

        public DateTime eventDate { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }

        public string source { get; set; }

        public string venue { get; set; }

        public string purposeOfEvent { get; set; }

        public int groupNumber { get; set; }

        public string bookingSummary { get; set; }

        public bool sendMail { get; set; }

        public bool sendText { get; set; }

        #endregion

        #region "Customer Details"

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        public string mainContactNo { get; set; }

        public string secondContactNo { get; set; }

        public string houseNumber { get; set; }

        public string address { get; set; }

        public string postCode { get; set; }

        public string twitter { get; set; }

        public string facebook { get; set; }

        #endregion

        #region "Event Information"



        #endregion

        #region "Financial Information"

        public string bookingStatus { get; set; }

        public decimal totalAmount { get; set; }

        public decimal totalDeposit { get; set; }

        public decimal amountPerPerson { get; set; }

        #endregion


    }

   
}