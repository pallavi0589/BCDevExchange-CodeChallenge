﻿using System;
using service.transport.common.Entity;

namespace service.transport.data;

public interface ITransportRepo
{
    Task<IEnumerable<TransportationOption>> GetTransportationOptionsAsync();
    Task<TransportationOption> GetTransportationOptionAsync(int id);
    Task<TransportationOption> CreateTransportationOptionAsync(List<TransportationOption> transportationOption);
    Task<bool> DeleteTransportationOptionAsync(int id);
    Task<TransportationOption> UpdateTransportationOptionAsync(int id, TransportationOption transportationOption);
}

