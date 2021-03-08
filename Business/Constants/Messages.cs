using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarsListed = "Cars listed.";
        public static string CarsNoListed = "Cars can not listed.";
        public static string BrandsListed = "Brands listed.";
        public static string BrandsNoListed = "Brands can not listed.";
        public static string ColorsListed = "Colors listed.";
        public static string ColorsNoListed = "Colors can not listed.";
        public static string CarIsNotAvailable = "Car is not available.";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string AccessTokenCreated = "Access token created.";
        public static string UserAlreadyExists = "User already exists.";
        public static string UserRegistered = "User registered.";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error.";
        public static string SuccessfulLogin = "Successful login.";
    }
}
