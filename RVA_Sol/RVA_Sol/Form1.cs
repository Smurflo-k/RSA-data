using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RVA_Sol
{
  public partial class Form1 : Form
  {
    private BigInteger publicKey = 65537; // Задайте свое значение открытого ключа
    private BigInteger privateKey = 123456789; // Задайте свое значение закрытого ключа

    public Form1()
    {
      InitializeComponent();
    }

    private void btnCheckIntegrity_Click(object sender, EventArgs e)
    {
      // Получаем входные данные из текстового поля
      string inputData = txtInputData.Text;

      // Преобразуем входные данные в байтовый массив
      byte[] inputBytes = Encoding.UTF8.GetBytes(inputData);

      // Создаем экземпляр класса BigInteger из входных данных
      BigInteger inputNumber = new BigInteger(inputBytes);

      // Шифруем данные с использованием открытого ключа
      BigInteger encryptedNumber = BigInteger.ModPow(inputNumber, publicKey, privateKey);

      // Дешифруем данные с использованием закрытого ключа
      BigInteger decryptedNumber = BigInteger.ModPow(encryptedNumber, privateKey, publicKey);

      // Преобразуем результат дешифрования в байтовый массив
      byte[] decryptedBytes = decryptedNumber.ToByteArray();

      // Преобразуем байтовый массив в строку
      string decryptedData = Encoding.UTF8.GetString(decryptedBytes);

      // Выводим результаты
      lblEncryptedData.Text = "Зашифрованные данные: " + encryptedNumber.ToString();
      lblDecryptedData.Text = "Расшифрованные данные: " + decryptedData;

      // Проверяем целостность данных
      bool isIntegrityPreserved = inputData.Equals(decryptedData);
      lblIntegrity.Text = "Целостность данных: " + isIntegrityPreserved.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
