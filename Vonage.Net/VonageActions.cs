using System;
using Vonage.Net.Models;

namespace Vonage.Net
{
    public class VonageActions
    {
        public VonageActions()
        {
        }


        public static VonageResponse VonageResponse = new VonageResponse();// just a fake default response
        /// <summary>
        /// Returns token to user, that will be used to call Vonage actions
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static VonageResponse GetToken(string username, string password)
        {
            //Generate Meroxa API token

            try
            {

                var DummyResponse = new VonageResponse
                {
                    IsSuccessful = true,
                    message = "Login successful",
                    data = new data
                    {
                        Metadata = "YourSampleToken"
                    }
                };

                return DummyResponse;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return VonageResponse;
        }


        /// <summary>
        /// recieves a phonumber and sends the message to that number, needs a token to work
        /// </summary>
        /// <param name="Phonenumber"></param>
        /// <param name="message"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static VonageResponse SendWhatsappMessage(string Phonenumber, string message, string Token)
        {
            //call the Vonage API backend to send the messages

            try
            {
                var DummyResponse = new VonageResponse
                {
                    IsSuccessful = true,
                    message = "Message sent successfully successfully",
                    data = new data
                    {
                        Metadata = "Message ID"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return VonageResponse;

        }

        /// <summary>
        /// Get the status if a message, if read, delivered or not delivered
        /// </summary>
        /// <param name="MessageID"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static VonageResponse GetMessageStatus(string MessageID, string Token)
        {
            //call CreateSource list API

            try
            {
                var DummyResponse = new VonageResponse
                {
                    IsSuccessful = true,
                    message = "Message sent successfully successfully",
                    data = new data
                    {
                        Metadata = "Message Read" //or "not read" or "not delivered"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return VonageResponse;

        }



        /// <summary>
        /// To send an OTP to any phonenumber
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static VonageResponse SendOTP(string PhoneNumber, string Token)
        {
            //call Vonage OTP API and return a response to client

            try
            {
                var DummyResponse = new VonageResponse
                {
                    IsSuccessful = true,
                    message = "OTP sent successfully successfully",
                    data = new data
                    {
                        Metadata = "Message Read" 
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return VonageResponse;

        }


        /// <summary>
        /// Validates the previously sent OTP
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="OTP"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static VonageResponse Validate(string PhoneNumber, string OTP, string Token)
        {
            //call Vonage OTP API and validate the OTP and return a response to client

            try
            {
                var DummyResponse = new VonageResponse
                {
                    IsSuccessful = true,
                    message = "OTP validated successfully successfully",
                    data = new data
                    {
                        Metadata = "random message"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return VonageResponse;

        }


    }
}
