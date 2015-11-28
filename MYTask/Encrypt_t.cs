
// string to base64
System.Text.Encoding encode = System.Text.Encoding.ASCII ;
byte[]  bytedata = encode.GetBytes( "test");
string strPath = Convert.ToBase64String(bytedata, 0, bytedata.Length);


//string to md5
//引用
using System.Security.Cryptography;
using System.Text;

//具体代码如下(写在按钮的Click事件里):
byte[] result = Encoding.Default.GetBytes(this.tbPass.Text.Trim());    //tbPass为输入密码的文本框
MD5 md5 = new MD5CryptoServiceProvider();
byte[] output = md5.ComputeHash(result);
this.tbMd5pass.Text = BitConverter.ToString(output).Replace("-", ""); //tbMd5pass为输出加密文本的文本框
