﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChatAgent.Models
{
    public class HolidayData
    {
        public string HolidayReference { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public string StarRating { get; set; }
        public string TempRating { get; set; }
        public string Location { get; set; }
        public string PricePerNight { get; set; }

        //public static void Red(string message)
        //{
        //    System.Windows.Forms.RichTextBox chatAgent = Application.OpenForms["HolidayChatAgentForm"].Controls["chatAgent"] as System.Windows.Forms.RichTextBox;

        //    chatAgent.AppendText(Environment.NewLine);
        //    chatAgent.SelectionStart = chatAgent.TextLength;
        //    chatAgent.SelectionLength = message.Length;
        //    chatAgent.SelectionColor = Color.Red;
        //    chatAgent.AppendText(message);
        //    chatAgent.SelectionColor = chatAgent.ForeColor;
        //}

    }
}