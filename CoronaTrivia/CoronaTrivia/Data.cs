using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrivia
{
    class Data
    {
        //Fields
        protected int dataNumber;
        protected string dataTopic;
        protected string dataContent;
        protected string dataImage;
        //Properties
        public int DataNumber { get => dataNumber; set => dataNumber = value; }
        public string DataTopic { get => dataTopic; set => dataTopic = value; }
        public string DataContent { get => dataContent; set => dataContent = value; }
        public string DataImage { get => dataImage; set => dataImage = value; }
        //Constructors
        public Data() //Empty Constructor
        {

        }
        public Data(int dataNumber, string dataTopic, string dataContent) //Constructor without image
        {
            DataNumber = dataNumber;
            DataTopic = dataTopic;
            DataContent = dataContent;
        }
        public Data(int dataNumber, string dataTopic, string dataContent, string dataImage) //Full Constructor
        {
            DataNumber = dataNumber;
            DataTopic = dataTopic;
            DataContent = dataContent;
            DataImage = dataImage;
        }
    }
}
