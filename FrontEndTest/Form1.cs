using Linker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndTest
{
    public partial class Form1 : Form
    {

        private Connection linker;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            linker = new Connection(txtCnn.Text);
            linker.MessageRecieved += Linker_MessageRecieved;
        }

        delegate void SetTextCallBack(string text);

        private void addMessage(string text)
        {
            txtChat.Text += text + "\n";
        }

        private void Linker_MessageRecieved(object sender, MessageRecievedEventArgs e)
        {
            SetTextCallBack d = new SetTextCallBack(addMessage);
            this.Invoke(d, new object[] { e.message });
            
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            linker.Subscribe(new string[] { txtTopic.Text });
        }


    }
}
