﻿using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    public interface IOrderDetails
    {
        List<ProductSold> GetAllOrders();
    }
}
