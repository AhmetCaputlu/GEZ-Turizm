using Data_Access.Context;
using Data_Access.Entities.Enums;
using Data_Access.Entities.Users;
using Microsoft.AspNetCore.Identity;

class Program
{
    static void Main(string[] args)
    {
        GEZContext context = new GEZContext();
       




        WebUser webUser = new WebUser
        {
            Id = Guid.NewGuid(),
            CustomID = 1,
            CreatedTime = DateTime.Now,
            CreatedID = Guid.NewGuid(),
            CreatedComputerName = "Kayıt Yapan Kişinin Bilgisayar İsmi",
            CreatedIPAddress = "127.0.0.1",
            Status = DataStatus.Active,
            UserName = "SmokeStackk",
            EmailConfirmed = false,
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnabled = false,
            AccessFailedCount = 0,
        };
        context.Users.Add(webUser);
        context.SaveChanges();
       
        WebUserProfile webUserProfile = new WebUserProfile
        {
            UniqueIdentify = webUser.Id,
            FirstName = "Ahmet",
            LastName = "Çaputlu",
            PhoneNumber = "05418636529",
            TCN_PassportNumber = "25816792932",
            UserTier = Tier.Basic,
            BirthDate = new DateTime(2001, 07, 31),
            Gender = Gender.Male,
            PhotoPath = "Örnek Profil Fotoğrafı",
            CustomID = webUser.CustomID,
            CreatedTime = webUser.CreatedTime,
            CreatedID = webUser.CreatedID,
            CreatedComputerName = webUser.CreatedComputerName,
            CreatedIPAddress = "127.0.0.1",
            Status = webUser.Status,
        };
        context.Add(webUserProfile);
        context.SaveChanges();








    }
}