using AppPrivy.CrossCutting.Agregation;
using AppPrivy.CrossCutting.Fault;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.CrossCutting.Operations
{
    public class SendMail
    {
        private readonly IConfiguration _config;
        private Stream _stream { get; set; }
        private MailMessage _mailMessage { get; set; }
        private string _host { get; set; }
        private string _login { get; set; }
        private string _password { get; set; }
        private int _port { get; set; }
        private string _paty { get; set; }
        private string _body { get; set; }
        private string _to { get; set; }
        private bool _ssl { get; set; }
        private string _from { get; set; }
        private string _name { get; set; }


        public SendMail(IConfiguration config)
        {
            _config = config;
        }


        private void FullFill()
        {
            try
            {
                _host = _config.GetSection("smtp:host").Value;
                _login = _config.GetSection("smtp:login").Value;
                _password = _config.GetSection("smtp:password").Value;
                _port = Convert.ToInt32(_config.GetSection("smtp:port").Value);
                _to = _config.GetSection("smtp:to").Value;
                _ssl = bool.Parse(_config.GetSection("smtp:enablessl").Value);
                _name = _config.GetSection("smtp:name").Value;
                _from = _config.GetSection("smtp:from").Value;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private string PopulateBodyContato(ContactAgregation contactAgregation)
        {
            try
            {

                if (!string.IsNullOrEmpty(contactAgregation._path))
                {
                    using (_stream = new FileStream(contactAgregation._path, FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (TextReader tx = new StreamReader(_stream, Encoding.ASCII))
                        {
                            _body = tx.ReadToEnd();

                            if (!string.IsNullOrEmpty(_body))
                            {
                                _body = _body.Replace("{UserName}", contactAgregation._name);
                                _body = _body.Replace("{Email}", contactAgregation._email);
                                _body = _body.Replace("{Phone}", contactAgregation._phone);
                                _body = _body.Replace("{Subject}", contactAgregation._subject);
                                _body = _body.Replace("{Message}", contactAgregation._body);
                            }
                        }
                    }
                }

                return _body;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string PopulateBodyRecoveryMail(ContactAgregation contactAgregation)
        {
            try
            {

                if (!string.IsNullOrEmpty(contactAgregation._path))
                {
                    using (_stream = new FileStream(contactAgregation._path, FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (TextReader tx = new StreamReader(_stream, Encoding.ASCII))
                        {
                            _body = tx.ReadToEnd();

                            if (!string.IsNullOrEmpty(_body))
                            {
                                _body = _body.Replace("{UserName}", contactAgregation._name);
                                _body = _body.Replace("{Email}", contactAgregation._email);
                                _body = _body.Replace("{Phone}", contactAgregation._phone);
                                _body = _body.Replace("{Subject}", contactAgregation._subject);
                                _body = _body.Replace("{Message}", contactAgregation._url);
                            }
                        }
                    }
                }

                return _body;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task SendHtmlFormattedMail(ContactAgregation contact)
        {
            try
            {

                await Task.Run(() =>
                {

                    this.FullFill();

                    using (var _mailMessage = new MailMessage())
                    {
                        _mailMessage.From = new MailAddress(_from, _name, Encoding.UTF8);
                        _mailMessage.To.Add(_to);
                        _mailMessage.Subject = contact._subject;
                        _mailMessage.SubjectEncoding = Encoding.UTF8;
                        _mailMessage.IsBodyHtml = true;
                        _mailMessage.BodyEncoding = Encoding.UTF8;
                        _mailMessage.Body = this.PopulateBodyContato(contact);
                        _mailMessage.Priority = MailPriority.Normal;

                        Func<string, string, NetworkCredential> netWorkCredential = delegate (string login, string senha)
                        {
                            return new NetworkCredential(login, senha);
                        };

                        using (var smtp = new SmtpClient(_host, _port))
                        {
                            try
                            {
                                
                                smtp.Credentials = netWorkCredential(_login, _password);
                                smtp.UseDefaultCredentials = false;
                                smtp.EnableSsl = _ssl;
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.SendMailAsync(_mailMessage);
                            }
                            catch (SmtpException e)
                            {
                                new FaultException("SmtpClient", e);
                            }
                        }
                    }


                });

            }
            catch (Exception e)
            {
                new FaultException("ESendHtmlFormattedMail", e);
            }


        }

        public async Task SendHtmlRecoveredMail(ContactAgregation contact)
        {
            try
            {

                await Task.Run(() =>
                {

                    this.FullFill();

                    using (var _mailMessage = new MailMessage())
                    {
                        _mailMessage.From = new MailAddress(_from, _name, Encoding.UTF8);
                        _mailMessage.To.Add(contact._to);
                        _mailMessage.Subject = contact._subject;
                        _mailMessage.SubjectEncoding = Encoding.UTF8;
                        _mailMessage.IsBodyHtml = true;
                        _mailMessage.BodyEncoding = Encoding.UTF8;
                        _mailMessage.Body = this.PopulateBodyRecoveryMail(contact);
                        _mailMessage.Priority = MailPriority.Normal;


                        Func<string, string, NetworkCredential> netWorkCredential = delegate (string login, string senha)
                        {
                            return new NetworkCredential(login, senha);
                        };

                        using (var smtp = new SmtpClient(_host, _port))
                        {
                            try
                            {
                                smtp.Credentials = netWorkCredential(_login, _password);
                                smtp.UseDefaultCredentials = false;
                                smtp.EnableSsl = _ssl;
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.SendMailAsync(_mailMessage);
                            }
                            catch (SmtpException e)
                            {
                                new FaultException("SmtpClient", e);
                            }
                        }
                    }


                });

            }
            catch (Exception e)
            {
                new FaultException("SendHtmlRecoveredMail", e);
            }


        }

    }
}
