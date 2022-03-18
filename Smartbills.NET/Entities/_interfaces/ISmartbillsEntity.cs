using System;

namespace Smartbills.Client.Entities
{
    public interface ISmartbillsEntity
    {
        Guid Id { get; set; }
    }
}