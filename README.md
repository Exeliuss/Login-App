# Login-App
A simple Login Application I wrote using C# for my school assignment.

# Windows Forms Login Uygulaması

Kullanıcı kayıt/giriş akışı, şifre göster/gizle, basit doğrulama ve (opsiyonel) yerel **SQLite** veri saklama desteği olan bir **Windows Forms** örnek projesi. .NET Framework 4.7.2 üzerinde çalışır ve Visual Studio ile derlenir.

## 🚀 Özellikler
- **Kayıt Ol / Giriş Yap** ekranları  
- **Şifre göster/gizle** (PasswordChar toggle)  
- Temel **girdi doğrulama** (boş alan kontrolü vb.)  
- **Yerel SQLite** ile kalıcı kullanıcı saklama *(opsiyonel; ilk çalıştırmada DB oluşturulur)*  
- Basit, anlaşılır **Form** yapısı (yalnızca `Form` dosyalarıyla yönetim; ayrı `Db.cs` yok)

## 🛠 Kullanılan Teknolojiler
- **C#** / **.NET Framework 4.7.2**
- **Windows Forms**
- **SQLite** (Microsoft.Data.Sqlite) *(opsiyonel)*

## 📋 Gereksinimler
- **Windows 10/11**
- **Visual Studio 2019/2022** (Desktop development with .NET iş yükü)
- .NET **Framework 4.7.2** geliştirici paketleri

## ⚙️ Kurulum & Çalıştırma
1. Bu projeyi indir veya klonla:  
   ```bash
   git clone https://github.com/<kullanici>/<repo-adi>.git
   ```
2. Visual Studio ile çözümü aç: `File > Open > Project/Solution...`
3. Gerekliyse NuGet paketlerini yükle: `Tools > NuGet Package Manager > Restore`
4. Başlangıç projesini **WinFormsApp** olarak ayarla.
5. **F5** ile çalıştır.

> **Not (SQLite):** `login.db` dosyası uygulama dizininde otomatik oluşturulur. `Users` tablosu yoksa ilk açılışta oluşturulur. Test için *Kayıt Ol* ekranından kullanıcı ekleyebilirsin.

## 📂 Proje Yapısı
```
WinFormsApp/
├─ Forms/
│  ├─ FormLogin.cs
│  ├─ FormLogin.Designer.cs
│  ├─ FormRegister.cs
│  └─ FormRegister.Designer.cs
├─ Program.cs
├─ App.config
├─ packages.config
└─ README.md
```

## 💡 Kullanım
- **Giriş Yap:** Kayıtlı kullanıcı bilgileriyle giriş yap.  
- **Kayıt Ol:** E-posta/Kullanıcı adı ve şifre ile yeni hesap oluştur.  
- **Şifre Göster/Gizle:** Checkbox veya ikon ile `PasswordChar` değiştirilebilir.

## 🔧 Yapılandırma
- **SQLite dosya yolu:** Varsayılan olarak uygulama dizininde `login.db`  
- **Tablo şeması:**  
  ```sql
  CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY,
    Username TEXT UNIQUE,
    PasswordHash TEXT,
    CreatedAt DATETIME
  );
  ```
- **Güvenlik:** Demo projesinde basit akış vardır. Gerçek kullanım için mutlaka **bcrypt/argon2** gibi güçlü hash yöntemleri tercih edin.

## 📦 Derleme (CLI – opsiyonel)
Visual Studio olmadan komut satırıyla derlemek istersen:
```bat
"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe" WinFormsApp.sln /t:Rebuild /p:Configuration=Release
```

## 📸 Ekran Görüntüleri
*(Repo’ya ekledikten sonra bu bölüme görsellerin yolunu koyabilirsin.)*
```
docs/images/login.png
docs/images/register.png
```

## ❓ Sık Sorulanlar
**S: Veritabanı şart mı?**  
C: Hayır, SQLite opsiyoneldir. İstersen yalnızca form ve bellek içi doğrulama ile çalıştırabilirsin.  

**S: SQL Server zorunlu mu?**  
C: Hayır. Bu örnek, SQL Server olmadan çalışacak şekilde tasarlandı.  

**S: Şifreler nasıl saklanıyor?**  
C: Eğitim amaçlı örnekte sade bir yapı kullanılmıştır. Gerçek projelerde mutlaka güçlü hash ve salt yöntemleri kullanılmalıdır.  



## ⚠️ Güvenlik Notları
- Demo amaçlıdır.  
- Üretim ortamında:  
  - Güçlü şifre politikası  
  - Hash (bcrypt/argon2), salt  
  - Girdi doğrulama ve hata yönetimi  
  - Çoklu deneme kısıtları / CAPTCHA  
  - Şifre sıfırlama akışları

## 📄 Lisans
MIT License © 2025 [Adınız]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
