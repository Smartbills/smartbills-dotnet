namespace Smartbills.NET.Entities.Webhooks
{
    public static class SBWebhookEventTypes
    {

        public const string MerchantCreated = "merchant.created";
        public const string MerchantUpdated = "merchant.updated";
        public const string MerchantDeleted = "merchant.deleted";

        public const string MerchantCustomerCreated = "merchant.customer.created";
        public const string MerchantCustomerUpdated = "merchant.customer.updated";
        public const string MerchantCustomerDeleted = "merchant.customer.deleted";

        public const string MerchantReceiptCreated = "merchant.receipt.created";
        public const string MerchantReceiptUpdated = "merchant.receipt.updated";
        public const string MerchantReceiptDeleted = "merchant.receipt.deleted";



        public const string MerchantProductCreated = "merchant.product.created";
        public const string MerchantProductUpdated = "merchant.product.updated";
        public const string MerchantProductDeleted = "merchant.product.deleted";


        public const string MerchantProductVariantCreated = "merchant.product.variant.created";
        public const string MerchantProductVariantUpdated = "merchant.product.variant.updated";
        public const string MerchantProductVariantDeleted = "merchant.product.variant.deleted";


        public const string MerchantProductImageCreated = "merchant.product.image.created";
        public const string MerchantProductImageUpdated = "merchant.product.image.updated";
        public const string MerchantProductImageDeleted = "merchant.product.image.deleted";

        public const string MerchantProductModifierCreated = "merchant.product.modifier.created";
        public const string MerchantProductModifierUpdated = "merchant.product.modifier.updated";
        public const string MerchantProductModifierDeleted = "merchant.product.modifier.deleted";


        public const string MerchantPromoCodeCreated = "merchant.promocode.created";
        public const string MerchantPromoCodeUpdated = "merchant.promocode.updated";
        public const string MerchantPromoCodeDeleted = "merchant.promocode.deleted";


        public const string MerchantTaxCreated = "merchant.tax.created";
        public const string MerchantTaxUpdated = "merchant.tax.updated";
        public const string MerchantTaxDeleted = "merchant.tax.deleted";

        public const string MerchantVendorCreated = "merchant.vendor.created";
        public const string MerchantVendorUpdated = "merchant.vendor.updated";
        public const string MerchantVendorDeleted = "merchant.vendor.deleted";


        public const string LocationTableCreated = "location.table.created";
        public const string LocationTableUpdated = "location.table.updated";
        public const string LocationTableDeleted = "location.table.deleted";
        public const string MerchantTableCreated = "merchant.table.created";
        public const string MerchantTableUpdated = "merchant.table.updated";
        public const string MerchantTableDeleted = "merchant.table.deleted";

        public const string MerchantLocationCreated = "merchant.location.created";
        public const string MerchantLocationUpdated = "merchant.location.updated";
        public const string MerchantLocationDeleted = "merchant.location.deleted";


        public const string MerchantFeeCreated = "merchant.fee.created";
        public const string MerchantFeeUpdated = "merchant.fee.updated";
        public const string MerchantFeeDeleted = "merchant.fee.deleted";

        public const string MerchantEmployeeCreated = "merchant.employee.created";
        public const string MerchantEmployeeUpdated = "merchant.employee.updated";
        public const string MerchantEmployeeDeleted = "merchant.employee.deleted";
        public const string LocationEmployeeCreated = "location.employee.created";
        public const string LocationEmployeeUpdated = "location.employee.updated";
        public const string LocationEmployeeDeleted = "location.employee.deleted";

        // Loyalty events
        public const string LoyaltyProgramCreated = "loyalty.program.created";
        public const string LoyaltyProgramUpdated = "loyalty.program.updated";
        public const string LoyaltyProgramDeleted = "loyalty.program.deleted";
        public const string LoyaltyAccountCreated = "loyalty.account.created";
        public const string LoyaltyAccountUpdated = "loyalty.account.updated";
        public const string LoyaltyAccountDeleted = "loyalty.account.deleted";
        public const string LoyaltyTransactionCreated = "loyalty.transaction.created";

        // Organization events
        public const string OrganizationCreated = "organization.created";
        public const string OrganizationUpdated = "organization.updated";
        public const string OrganizationDeleted = "organization.deleted";
        public const string OrganizationMemberCreated = "organization.member.created";
        public const string OrganizationMemberUpdated = "organization.member.updated";
        public const string OrganizationMemberDeleted = "organization.member.deleted";
        public const string OrganizationInvitationCreated = "organization.invitation.created";
        public const string OrganizationInvitationAccepted = "organization.invitation.accepted";
        public const string OrganizationInvitationRejected = "organization.invitation.rejected";

        // Expense events
        public const string ExpenseCreated = "expense.created";
        public const string ExpenseUpdated = "expense.updated";
        public const string ExpenseDeleted = "expense.deleted";
        public const string ExpenseCategoryCreated = "expense.category.created";
        public const string ExpenseCategoryUpdated = "expense.category.updated";
        public const string ExpenseCategoryDeleted = "expense.category.deleted";

        // Invoice events
        public const string InvoiceCreated = "invoice.created";
        public const string InvoiceUpdated = "invoice.updated";
        public const string InvoiceDeleted = "invoice.deleted";
        public const string InvoicePaid = "invoice.paid";
        public const string InvoicePaymentCreated = "invoice.payment.created";
        public const string InvoiceOverdue = "invoice.overdue";

        // Merchant invoice events
        public const string MerchantInvoiceCreated = "merchant.invoice.created";
        public const string MerchantInvoiceUpdated = "merchant.invoice.updated";
        public const string MerchantInvoiceDeleted = "merchant.invoice.deleted";
        public const string MerchantInvoicePaid = "merchant.invoice.paid";
        public const string MerchantInvoicePaymentCreated = "merchant.invoice.payment.created";
        public const string MerchantInvoiceOverdue = "merchant.invoice.overdue";


        public const string OrganizationExpenseCreated = "organization.expense.created";
        public const string OrganizationExpenseUpdated = "organization.expense.updated";
        public const string OrganizationExpenseDeleted = "organization.expense.deleted";


        public const string OrganizationExpenseCategoryCreated = "organization.expense.category.created";
        public const string OrganizationExpenseCategoryUpdated = "organization.expense.category.updated";
        public const string OrganizationExpenseCategoryDeleted = "organization.expense.category.deleted";

        public const string UserCreated = "user.created";
        public const string UserUpdated = "user.updated";
        public const string UserDeleted = "user.deleted";
    }
}
