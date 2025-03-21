using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{
    public record SBBankAccount : SBEntity
    {
        public SBBankAccount()
        {
        }


        public string Type { get; set; }

        public string SubType { get; set; }

        public string Name { get; set; }

        public string Mask { get; set; }

        public string OfficialName { get; set; }

        public SBBankAccountBalance Balance { get; set; }

    }
}
