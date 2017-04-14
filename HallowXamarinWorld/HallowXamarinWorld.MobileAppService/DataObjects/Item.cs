﻿using Microsoft.Azure.Mobile.Server;

namespace HallowXamarinWorld.MobileAppService.DataObjects
{
    public class Item : EntityData
    {
        public string Text { get; set; }
        public string Description { get; set; }
    }
}