using System.Windows.Forms;
namespace SimpleiPhoneToolkit;
public class MainForm:Form{
 public MainForm(){
  Text="Simple iPhone Toolkit";
  Width=600; Height=400;
  Controls.Add(new Label{Text="Simple iPhone Toolkit",Left=20,Top=20,AutoSize=true});
  Controls.Add(new Button{Text="Detect Device",Left=20,Top=60,Width=150});
  Controls.Add(new Button{Text="Enter Recovery",Left=20,Top=100,Width=150});
  Controls.Add(new Button{Text="Exit Recovery",Left=20,Top=140,Width=150});
 }
}