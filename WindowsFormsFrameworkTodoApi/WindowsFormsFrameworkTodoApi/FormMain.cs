using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsFrameworkTodoApi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод кнопки отправки запроса
        /// </summary>
        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            getServerAddress();            
            
            try
            {
                // Создание объекта WebRequest
                WebRequest webRequest = WebRequest.Create(getServerAddress());
                doRequest(webRequest, getCommand());
            }
            catch(UriFormatException ex)
            {
                MessageBox.Show("Некорректный адрес сервера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Выполняет запрос на сервер
        /// </summary>
        /// <param name="webRequest"> Объект WebRequest </param>
        /// <param name="commandByte"> Команда для отправки </param>
        private void doRequest(WebRequest webRequest, byte[] commandByte)
        {
            try 
            {
                webRequest.Method = getRequestMethod(webRequest);
                
                // Если метод POST, PUT, DELETE, то необходимо записывать данные
                if (webRequest.Method != "GET")
                {
                    webRequest.ContentLength = commandByte.Length;

                    using (Stream dataStream = webRequest.GetRequestStream())
                    {
                        dataStream.Write(commandByte, 0, commandByte.Length);
                    }
                }

                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    using (Stream dataStream = webResponse.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        richTextBoxAnswer.Text = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Получение адреса сервера
        /// </summary>
        private string getServerAddress()
        {
            return textBoxServer.Text;
        }

        /// <summary>
        /// Получение текста команды
        /// </summary>
        private byte[] getCommand()
        {
            return Encoding.UTF8.GetBytes(richTextBoxCommand.Text);
        }

        private string getRequestMethod(WebRequest webRequest)
        {
            foreach(RadioButton requestRadio in 
                panelServerAndCommand.Controls.Cast<Control>().Where(x => x is RadioButton).Select(x => x as RadioButton))
            {
                if (requestRadio.Checked)
                {
                    if (requestRadio.Text != "GET")
                    {
                        webRequest.ContentType = "application/json";
                    }
                    return requestRadio.Text;
                }
            }
            return "GET";
        }
    }
}
