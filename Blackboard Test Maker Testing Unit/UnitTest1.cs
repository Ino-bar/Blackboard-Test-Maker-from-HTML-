using System;
using Xunit;
using Blackboard_Test_Maker__from_HTML_;
using System.Windows.Forms;
using System.Management.Automation;

namespace Blackboard_Test_Maker_Testing_Unit
{
    public class UnitTest1
    {
        //private OpenFileDialog ChooseTestFormWindow;
        public string TestFormFilePath;
        [Fact]
        public void Test1()
        {
            Assert.Equal(8.0, 5 + 3, 0);
        }
        [Fact]
        public string ReturnTestFormFilePath()
        {
            return TestFormFilePath;
        }
        [Fact]
        public void chooseTestForm()
        {
            TestFormFilePath = "C:\\Users\\jdunbar\\Desktop\\output.html";
            Assert.Equal("C:\\Users\\jdunbar\\Desktop\\output.html", TestFormFilePath);
        }
    }
    public class FileConverter
    {
        UnitTest1 NewTest1 = new UnitTest1();
        
        PowerShell powerShell = PowerShell.Create();
        public void ConvertTestFormToHTML()
        {
            NewTest1.chooseTestForm();
            string filePath = NewTest1.ReturnTestFormFilePath();
            powerShell.AddCommand("cd " + filePath);
            powerShell.AddCommand("");
        }
    }
}
