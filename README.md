# 🧩 Add PPPoE Client to MikroTik using VB.Net & Tik4Net

A simple Windows Forms application built with **VB.Net** and **Tik4Net** library to automatically add PPPoE users to a **MikroTik Router** via the **API interface**.  
This project is part of the **D-Tech Project** series — focused on IT automation, networking, and programming.

---

## 🚀 Features

- ✅ Connect to MikroTik Router using API  
- ✅ Add new PPPoE clients automatically  
- ✅ Simple GUI with input validation  
- ✅ Status indicator for connection state  
- ✅ Clear input fields easily after data entry  

---

## 🧠 How It Works

1. The app establishes a connection to the MikroTik router using:
   ```vbnet
   Connection = ConnectionFactory.CreateConnection(TikConnectionType.Api)
   Connection.Open("192.168.200.1", "user1", "user1234")
When the user clicks Add, the app executes the following command:

/ppp/secret/add name=USERNAME password=PASSWORD service=pppoe


The new PPPoE client is added instantly — without needing to open Winbox manually.

🧩 Requirements
Windows OS
.NET Framework 4.7 or later
Tik4Net library
MikroTik Router with API service enabled

⚙️ Installation

Clone this repository:
git clone https://github.com/yourusername/Add-PPPoE-Client-MikroTik-VBNet.git


Open the project in Visual Studio.
Restore dependencies (Tik4Net DLL).
Build and run the project.

🖥️ Screenshot

Screenshot.png

🧑‍💻 Author

D-Tech Project
Website: https://dtech-project.com
YouTube: D-Tech Project
Facebook Page: DTech Project

📜 License

This project is licensed under the MIT License — feel free to use, modify, and distribute with attribution.

⭐ Support

If you find this project useful, please consider:

🌟 Giving it a star on GitHub

🔔 Subscribing to D-Tech Project on YouTube

💬 Sharing it with your IT and networking community
