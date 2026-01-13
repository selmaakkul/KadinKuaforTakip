# Kadın Kuaförü Müşteri İlişkileri ve Hizmet Talep Yönetim Sistemi Projesi
## Proje Açıklaması

Proje, bir kadın kuaförüne ait müşteri ilişkileri ve hizmet taleplerinin yönetilmesini amaçlayan bir uygulamadır. Sistem üzerinden müşterilerin hizmet talepleri kayıt altına alınmakta ve bu talepler ilgili personel ataması yapılmaktadır. Ayrıca taleplerin durumu süreç boyunca güncellenerek takip edilebilmektedir. Proje, kuaför içerisindeki iş akışını düzenlemeyi hedefleyen eğitim a
## Proje Özellikleri

**Giriş Ekranı**: Kullanıcının yetki durumuna göre ilgili sayfalara yönlendirme yapılır.

**Müşteri Yönetimi**: Müşteri ekleme, düzenleme ve silme işlemleri gerçekleştirilir.

**Talep Oluşturma**: Müşterilere ait hizmet talepleri sisteme kaydedilir.

**Personel Atama**: Oluşturulan taleplere uygun personel ataması yapılır.

**Durum Güncelleme**: Müşteri taleplerinin süreç durumu güncellenir.

**Personel Performans Takibi**: Yönetici, personel listesini ve performans puanlarına göre durumlarını görüntüleyebilir.

**Hizmet ve Ücret Bilgileri**: Sunulan hizmetler ve hizmet ücretleri görüntülenebilir.

**Raporlama**: Müşteri bilgileri, talep durumu, atanan personel ve tarih bilgilerini içeren raporlar görüntülenebilir.
## **Kullanılan Teknolojiler**

- **C# (.NET Framework)**  
- **Windows Forms** (Masaüstü uygulama tasarımı)  
- **MySQL** (Veritabanı)  
- **Varlık Katmanı**: Katmanlı mimari yapısı (DAL, BLL)
 ## 📷 Uygulama Ekran Görüntüleri
## **🌟Giriş Ekranı**

  <img width="638" height="459" alt="Ekran görüntüsü 2026-01-13 180841" src="https://github.com/user-attachments/assets/ba1d7edd-d930-4ba1-9065-ce337ad8e054" />
 
  
  Giriş ekranında kullanıcı, kendisine tanımlı kullanıcı adı ve şifre bilgileri ile sisteme giriş yapar. Giriş işleminin başarılı olabilmesi için bilgilerin doğru girilmesi gerekmektedir. Kullanıcının yetkisine göre sistem, yönetici, destek personeli veya çağrı merkezi personeline ait ilgili ekrana yönlendirme yapar.


## **⭐Müşteri Yönetimi ve Talep Ekleme Ekranı**

<img width="805" height="509" alt="Ekran görüntüsü 2026-01-13 181915" src="https://github.com/user-attachments/assets/202b11cb-d114-40bd-a06b-d166c7349b02" />


Bu ekranda sol kısımda müşteri listesi yer almaktadır. Çağrı merkezi personeli, bu alan üzerinden müşteri ekleme, düzenleme ve silme işlemlerini gerçekleştirebilir.
Aynı ekranın sağ kısmı üzerinden seçilen müşteri için hizmet talebi oluşturulabilir. Talep ekleme işlemleri çağrı merkezi personeli tarafından yapılmakta olup, müşteri talepleri sistem üzerinden kayıt altına alınmaktadır.

  **Müşteri Ekleme**  

  <img width="794" height="512" alt="Ekran görüntüsü 2026-01-13 182711" src="https://github.com/user-attachments/assets/e6aa4af9-0983-42d7-a9c6-2bc9376a82d3" />

Açılan küçük ekranda müşteri ad ve soyad bilgileri girildikten sonra Kaydet butonuna basılarak yeni müşteri sisteme eklenir. Bu işlemi çağrı merkezi personeli gerçekleştirmektedir.


 **Müşteri Bilgi Düzenleme** 

 <img width="765" height="500" alt="Ekran görüntüsü 2026-01-13 182739" src="https://github.com/user-attachments/assets/b5de994e-77c6-4ba6-b71b-b3f42176d7c4" />

 Açılan küçük pencerede müşteri bilgileri düzenlenir ve işlemin tamamlanmasının ardından güncellenmiş bilgiler müşteri listesinde görüntülenir. Bu işlemi çağrı merkezi personeli gerçekleştirmektedir.

 **Müşteri Hizmet Talebi Oluşturma** 

 <img width="787" height="506" alt="Ekran görüntüsü 2026-01-13 182822" src="https://github.com/user-attachments/assets/1679a568-648c-4e86-99a6-a9d7bb2c3486" />

 Sağ kısımda müşteri adı ve soyadı girilerek talep seçimi yapılır ve bilgiler kaydedilir. Kaydedilen talepler, destek personelinin talep listesine düşer. Kayıt işlemi tamamlandıktan sonra, talebi oluşturulan müşteri sol taraftaki müşteri listesinden seçilerek Sil butonu ile listeden kaldırılabilir. Bu işlemi çağrı merkezi personeli gerçekleştirmektedir.



## **⭐⭐Personel Atama ve Durum Güncelleme Ekranı**

<img width="1057" height="597" alt="Ekran görüntüsü 2026-01-13 184309" src="https://github.com/user-attachments/assets/27891ce2-7f3d-41be-b467-6a38a9d812bd" />


Mevcut ekranda, çağrı merkezi personeli tarafından girilen müşterilere ait ID, ad, soyad, talep edilen hizmet ve durum bilgilerini içeren bir liste görüntülenmektedir. Destek personeli, listeden ilgili müşteriyi seçerek sağ alt kısımda bulunan açılır listeler üzerinden personel ataması yapar ve talep durumunu günceller. Güncelleme işlemi tamamlandıktan sonra ilgili kayıt listeden otomatik olarak kaldırılır ve güncellenen bilgiler yöneticinin raporlama ekranına aktarılır.
Bu işlemi destek personeli gerçekleştirmektedir.


## **⭐⭐⭐Yönetici Ekranı**

<img width="627" height="459" alt="Ekran görüntüsü 2026-01-13 185817" src="https://github.com/user-attachments/assets/350ee68d-f9a0-4860-89fd-7e269a5f9b86" />


Bu ekran, yöneticiye ait kontrol listelerinin bulunduğu ekrandır. Yönetici bu ekran üzerinden personel, hizmet ve raporlama bilgilerine erişim sağlayabilir.

 **Personel Listesi** 
 
 <img width="736" height="425" alt="Ekran görüntüsü 2026-01-13 185842" src="https://github.com/user-attachments/assets/6d5d5f91-a5d2-4cc4-aa3f-8e7374312278" />

Bu ekranda personelin ID, ad, soyad, rol ve performans puanı bilgileri görüntülenmektedir. Performans puanları görsel olarak renklendirilmiştir; 50’nin altında olanlar kırmızı, 50 ile 75 arasında olanlar sarı, 75’in üzerinde olanlar ise yeşil renkte gösterilmektedir.

 **Hizmet Listesi** 
 
<img width="729" height="436" alt="Ekran görüntüsü 2026-01-13 185854" src="https://github.com/user-attachments/assets/b935b26d-9702-462c-91ca-483ea3464488" />

 Bu ekranda hizmete ait ID, hizmet adı, hizmet açıklaması ve hizmet ücreti bilgileri görüntülenmektedir.

 **Rapor Ekranı** 
 
<img width="725" height="442" alt="Ekran görüntüsü 2026-01-13 185933" src="https://github.com/user-attachments/assets/cd13eaa6-697b-4b81-99d0-9a55c9bee6ff" />

 Rapor ekranında müşteri adı, soyadı, talep edilen hizmet ID’si ve tarih bilgileri görüntülenmektedir (tarih ve personel ID alanlarında mevcut bazı hatalar bulunmakta olup, bu hatalar ilerleyen süreçte düzeltilecektir).


 ## **🛠️Katmanlı Mimari Yapısı**

**Domain (Entity / Varlık / Model Katmanı)**: Uygulamada kullanılan müşteri, personel, hizmet ve talep gibi temel veri modellerini içerir.

**DAL (Veri Erişim Katmanı)**: Veritabanı ile ilgili tüm ekleme, silme, güncelleme ve listeleme işlemleri bu katmanda gerçekleştirilir.

**BLL (İş Mantığı Katmanı)**: Uygulamanın iş kuralları ve kontrolleri bu katmanda yönetilir.

**UI (Kullanıcı Arayüzü)**: Windows Forms kullanılarak oluşturulmuş kullanıcı arayüzünü içerir.

**MySQL**: Veritabanı bağlantıları ve sorgularının çalıştırıldığı veritabanı sistemidir.


 ## **💫Proje Tanıtım Videosu**

Projenin tanıtım videosunu izlemek için aşağıdaki bağlantıyı kullanabilirsiniz:  
https://youtu.be/Q2ABUCBpmRI

## **📞İletişim**

**Ad Soyad**: Selma Akkül  
**Telefon**: 0553 063 18 85 
**E-posta**: selmaakkul4@gmail.com


