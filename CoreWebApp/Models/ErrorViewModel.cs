using System;

namespace CoreWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class MenuItem
    {
        public string Id { get; set; }

        public string Text { get; set; }
    }
}
