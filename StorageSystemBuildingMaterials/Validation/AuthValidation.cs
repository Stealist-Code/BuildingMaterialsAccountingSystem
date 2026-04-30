using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace StorageSystemBuildingMaterials.Validation
{
    /// <summary>
    /// Класс валидации для авторизации, вся логика валидации, связанная с авторизацией должна быть тут!!!
    /// </summary>
    public class AuthValidation : IAuthValidation
    {
        private static readonly string _pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        /// <summary>
        /// Проверяет, является ли строка корректным email-адресом (с помощью регулярного выражения).
        /// </summary>
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            email = email.Trim();

            return Regex.IsMatch(email, _pattern);
        }

        /// <summary>
        /// Метод, который проверяет введенные поля при регистрации пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateRegisterRequest(RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.FirstName) || string.IsNullOrWhiteSpace(request.LastName) ||
                string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                throw new Exception("FillFieldsForRegister");
            }

            if (!IsValidEmail(request.Email))
            {
                throw new Exception("InvalidEmail");
            }

            if (!ValidatePassword(request.Password))
            {
                throw new Exception("PasswordMustCompleteConditions");
            }

            if (request.Password != request.ConfirmPassword)
            {
                throw new Exception("PasswordsDoNotMatch");
            }
        }

        /// <summary>
        /// Проверка логина на валидность (заполнение всех полей, а также проверка электронной почты на валидность)
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateLogin(AuthenticateRequest authenticateRequest)
        {
            if (string.IsNullOrEmpty(authenticateRequest.Email) || string.IsNullOrEmpty(authenticateRequest.Password))
            {
                throw new Exception("FillFieldsForAuth");
            }

            if (!IsValidEmail(authenticateRequest.Email))
            {
                throw new Exception("InvalidEmail");
            }
        }

        /// <summary>
        /// Проверка на наличие в пароле спец символов, цифр, заглавных и строчных букв, длины минимум в 8 символов
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                return false;
            }

            bool hasDigit = false;
            bool hasSpecial = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (var ch in password)
            {

                if (char.IsDigit(ch))
                {
                    hasDigit = true;
                }

                if (char.IsUpper(ch))
                {
                    hasUpper = true;
                }

                if (char.IsLower(ch))
                {
                    hasLower = true;
                }

                if (!char.IsLetterOrDigit(ch))
                {
                    hasSpecial = true;
                }

                if (hasDigit && hasSpecial && hasUpper && hasLower)
                {
                    return true;
                }
            }

            return false;
        }
    }
}