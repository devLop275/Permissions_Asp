using System;
using System.Collections.Generic;

namespace PermissionBasedAuthorizationIntDotNet5.Contants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsList(string module)
        {
            if(module == "Products")
            {
                return new List<string>()
                {
                $"Permissions.{module}.View",
                $"Permissions.{module}.Create",
                $"Permissions.{module}.Edit",
                $"Permissions.{module}.Delete",
                $"Permissions.{module}.FirstNamePro",
                $"Permissions.{module}.LastNamePro",
                $"Permissions.{module}.PhonePro",
                $"Permissions.{module}.FilePro",
                };
            }
            else if(module == "Author")
            {
                return new List<string>()
                {
                $"Permissions.{module}.Create_Author",
                $"Permissions.{module}.FullName_Author_Create",
                $"Permissions.{module}.Phone_Auhor_Create",
                $"Permissions.{module}.Commantaire_Author_Create",
                $"Permissions.{module}.Edit_Author",
                $"Permissions.{module}.FullName_Author_Edit",
                $"Permissions.{module}.Phone_Auhor_Edit",
                $"Permissions.{module}.Commantaire_Author_Edit",
                $"Permissions.{module}.Delete_Author",
                };
            }
            else
            {
                return null;
            }
             
        }

        public static List<string> GenerateAllPermissions()
        {
            var allPermissions = new List<string>();

            var modules = Enum.GetValues(typeof(Modules));

            foreach (var module in modules)
                allPermissions.AddRange(GeneratePermissionsList(module.ToString()));

            return allPermissions;
        }

        public static class Products
        {
            public const string View = "Permissions.Products.View";
            public const string Create = "Permissions.Products.Create";
            public const string Edit = "Permissions.Products.Edit";
            public const string Delete = "Permissions.Products.Delete";
            public const string FirstNamePro = "Permissions.Products.FirstNamePro";
            public const string LastNamePro = "Permissions.Products.LastNamePro";
            public const string PhonePro = "Permissions.Products.PhonePro";
            public const string FilePro = "Permissions.Products.FilePro";

        }
        public static class Author
        {
            public const string Create = "Permissions.Author.Create_Author";
            public const string FullNameAuthorCreate = "Permissions.Author.FullName_Author_Create";
            public const string PhoneAuhorCreate = "Permissions.Author.Phone_Auhor_Create";
            public const string CommantaireAuthorCreate = "Permissions.Author.Commantaire_Author_Create";
            public const string Edit = "Permissions.Author.Edit_Author";
            public const string FullNameAuthorEdit = "Permissions.Author.FullName_Author_Edit";
            public const string PhoneAuhorEdit = "Permissions.Author.Phone_Auhor_Edit";
            public const string CommantaireAuthorEdir = "Permissions.Author.Commantaire_Author_Edit";
            public const string Delete = "Permissions.Author.Delete_Author";
        }
    }
}