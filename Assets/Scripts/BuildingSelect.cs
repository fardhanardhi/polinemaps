using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuildingSelect : MonoBehaviour {

    public GameObject scrollArea;
    public Text infoText;
    private bool isShowing;
    public string detailsText;

    // Use this for initialization
    void Start () {
        detailsText = "";
        isShowing = false;
        scrollArea.gameObject.SetActive(isShowing);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            detailsText = "";
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name + " Clicked!");

                switch (hit.transform.name)
                {
                    case "TeksPolinema":
                        detailsText = "Teks Polinema\n" +
                            "Merupakan Signboard teks yang bertuliskan “Politeknik Negeri Malang” yang terletak di paling depan kampus Polinema yang bisa dilihat oleh umum dari luar kampus, dan juga sebagai salah satu ikon identitas Politeknik Negeri Malang.";
                        break;
                    case "Siti":
                        detailsText = "Gedung Sipil Teknik Informatika\n" +
                            "Gedung ini memiliki 8 lantai dan dilengkapi dengan lift untuk mempercepat akses ke semua lantai.\n" +
                            "Lantai 1 sampai 6 digunakan oleh mahasiswa jurusan Teknik Sipil, sedangkan lantai 7 dan 8 digunakan " +
                            "untuk mahasiswa jurusan Teknik Informatika.\n" +
                            "Di gedung ini khususnya lantai 7 terdapat laboratorium dengan jumlah komputer yang memadai dan " +
                            "ruang kelas yang dilengkapi dengan fasilitas seperti AC, proyektor, papan tulis, meja, kursi. " +
                            "Selain itu di lantai 7 juga ada kantin yang menjual makanan ringan dan kue.";
                        break;
                    case "MasjidRaya":
                        detailsText = "Masjid Raya An-Nur\n" +
                            "Masjid Raya An-Nur berada dekat dengan pintu masuk Polinema, sehingga posisinya " +
                            "mudah dijangkau juga oleh masyarakat umum.\n" +
                            "Masjid ini luas dan memiliki 3 lantai, namun yang bisa digunakan hanya lantai 1 saja " +
                            "karena masih dalam proses pembangunan.\n" +
                            "Setelah ini akan sering digunakan untuk acara seperti " +
                            "syiar islam, pengajian, istighosah, shalat jumat, dan kegiatan kerohanian lainnya.";
                        break;
                    case "Kantin":
                        detailsText = "Kantin\n" +
                            "Kantin kampus berada di lantai paling atas tempat parkir sepeda motor.\n" +
                            "Kantin kampus menyediakan berbagai macam menu makanan dan minuman dengan harga yang terjangkau bagi mahasiswa.\n" +
                            "Kantin ini dilengkapi dengan meja dan kursi yang cukup banyak, ada juga wifi gratis yang bisa diakses mahasiswa.";
                        break;
                    case "Masjid":
                        detailsText = "Masjid An-Nur\n" +
                            "Masjid An-Nur digunakan oleh semua warga Polinema untuk menjalankan ibadah.\n" +
                            "Masjid ini juga sering digunakan untuk acara-acara kerohanian seperti istighosah, shalat jumat, tempat mengaji bersama, dan kegiatan lainnya.";
                        break;
                    case "Grapol":
                        detailsText = "Graha Polinema\n" +
                            "Graha polinema digunakan untuk event-event besar seperti seminar dan lomba.\n" +
                            "Di dalamnya terdapat lapangan basket yang sering digunakan untuk latihan dan lomba.\n" +
                            "Ada juga perpustakaan di 3. Basement digunakan untuk parkir sepeda motor dan mobil. Lantai 2 untuk menonton pertandingan maupun acara-acara lainnya.\n" +
                            "Baru-baru ini Graha Polinema digunakan untuk perlombaan KRI (Kontes Robot Indonesia) 2018 yang merupakan kontes robot tingkat nasional.";
                        break;
                    case "AA":
                        detailsText = "Gedung AA\n" +
                            "Gedung ini merupakan kantor pusat informasi dan administrasi bagi mahasiswa Politeknik Negeri Malang.\n" +
                            "Mahasiswa mengurus administrasi seperti pembuatan KTM yang hilang, daftar ulang, meminta keringanan UKT dan administrasi lainnya di gedung ini.";
                        break;

                    case "AB":
                        detailsText = "Gedung AB\n" +
                            "Gedung AB adalah salah satu fasilitas yang disediakan untuk mahasiswa jurusan Administrasi Niaga yang terdiri dari prodi D-IV Manajemen Pemasaran dan D-III Administrasi Bisnis.\n" +
                            "Gedung ini memiliki ruang kelas, laboratorium dan studio untuk menunjang kegiatan belajar mengajar mahasiswa, yaitu Lab. bahasa, Lab. Keyboarding skill, Lab. Komputer, Lab. Pemasaran, Lab. Pengetikan Bisnis, Lab. Simulasi Bisnis, Studio Alat Bantu, Studio Audio Visual, dan Studio Dokumentasi.\n" +
                            "Setiap ruangannya dilengkapi dengan AC, proyektor, meja, dan kursi.";
                        break;

                    case "AC":
                        detailsText = "Gedung AC\n" +
                            "Gedung AB, gedung AC juga digunakan oleh mahasiswa jurusan Administrasi Niaga dan Akuntansi, karena gedung AB tidak mencukupi.\n" +
                            "Fasilitas di gedung ini sama seperti gedung AB yang dilengkapi dengan ruang kelas, laboratorium untuk praktikum, dan fasilitas penunjang seperti AC, proyektor, papan tulis, meja dan kursi di setiap ruangan.";
                        break;

                    case "AD":
                        detailsText = "Gedung AD\n" +
                            "Gedung AD digunakan oleh mahasiswa jurusan Akuntansi yang terdiri dari prodi D-IV Akuntansi Manajemen dan D-III Akuntansi.\n" +
                            "Selain ruang kelas dan laboratorium, di gedung ini juga terdapat koperasi yang menjual kebutuhan mahasiswa seperti alat tulis, makanan ringan, dan kue. Fasilitas ini memudahkan mahasiswa untuk membeli kebutuhan mereka, karena lebih dekat.";
                        break;

                    case "AE":
                        detailsText = "Gedung AE\n" +
                            "Gedung AE merupakan gedung kuliah mahasiswa jurusan Administrasi Niaga dan Akuntansi.\n" +
                            "Gedung ini mempunyai ruang kelas dan laboratorium untuk kegiatan praktikum, Laboratorium tersebut yaitu Lab. Akutansi Manual dan Komputerisasi, Lab. Bahasa Inggris, Lab. Komputer, Lab. Komunikasi Bisnis, Lab. Multimedia, dan Lab. Perbankan.\n" +
                            "Fasilitas lainnya yaitu AC, papan tulis, proyektor, meja, dan kursi. Diharapkan fasilitas ini bisa menunjang kegiatan belajar mahasiswa.";
                        break;

                    case "AF":
                        detailsText = "Gedung AF\n" +
                            "Gedung AF digunakan oleh mahasiswa khususnya jurusan Teknologi Informasi yang terdiri dari prodi D-IV Teknik Informatika dan D-III Manajemen Informatika.\n" +
                            "Di gedung ini terdapat laboratorium untuk praktikum dan ruang kelas besar maupun reguler. Ada juga ruang baca untuk membantu mahasiswa memperoleh informasi mengenai materi mata kuliah mereka. Gedung ini juga terdapat laboratorium yang digunakan mahasiswa akuntansi untuk praktikum.";
                        break;

                    case "AG":
                        detailsText = "Gedung AG\n" +
                            "Gedung AG merupakan gedung untuk kegiatan belajar mengajar mahasiswa jurusan Teknik Listrik dengan program studi D-IV Sistem Kelistrikan dan D-III Teknik Listrik.\n" +
                            "Mahasiswa PLN juga menggunakan gedung ini. Di gedung ini terdapat ruang kelas, laboratorium, dan kantin yang menjual makanan ringan dan kue. Selain itu, di gedung ini terdapat fasilitas untuk fotocopy sehingga mahasiswa tidak perlu jauh – jauh mencari tempat fotocopy.";
                        break;

                    case "AH":
                        detailsText = "Gedung AH\n" +
                            "Gedung AH digunakan oleh mahasiswa jurusan Teknik Elektronika dengan program studi D-IV Teknik Elektronika dan D-III Teknik Elektronika.\n" +
                            "Ada sebagian ruangan di gedung ini yang dipakai mahasiswa jurusan Teknik Telekomunikasi dengan prodi D-III Teknik Telekomunikasi dan D-IV Jaringan Telekomunikasi Digital.\n" +
                            "Selain dua jurusan itu, mahasiswa GMF juga menggunakan gedung tersebut untuk kegiatan belajar mengajar.";
                        break;

                    case "AI":
                        detailsText = "Gedung AI\n" +
                            "Gedung AI merupakan gedung mahasiswa jurusan Teknik Telekomunikasi dengan program studi D-III Teknik Telekomunikasi dan D-IV Jaringan Telekomunikasi Digital.\n" +
                            "Di gedung ini terdapat ruang kelas, dan laboratorium. Laboratorium tersebut terdiri dari Lab. Elektronika Dasar, Lab. Jaringan Komputer, Lab. Jaringan Telekomunikasi, Lab. Komunikasi Data, Lab. Mikrokontroler, Lab. Radio Frekuensi (Uji Antena 2.4 GHz), dan Lab. Sistem Transmisi.";
                        break;

                    case "AJ":
                        detailsText = "Gedung AJ\n" +
                            "Gedung AJ merupakan bengkel elektronika dan laboratorium bagi mahasiswa jurusan Teknik Elektronika.\n" +
                            "Bengkel ini digunakan untuk kegiatan praktikum seperti perancangan listrik, pembuatan analog digital, mengelas, dan praktikum lainnya.";
                        break;

                    case "AK":
                        detailsText = "Gedung AK\n" +
                            "Gedung AK digunakan sebagai bengkel kelistrikan mahasiswa jurusan Teknik Listrik.\n" +
                            "Bengkel ini dilengkapi dengan alat-alat yang menunjang kegiatan praktikum. Di sini mahasiswa bisa melakukan Instalasi APP (Alat Pengukur dan Pembatas), Instalasi MCC (Motor Control Centre), Instalasi Penerangan, dan Mekanik.";
                        break;

                    case "AL":
                        detailsText = "Gedung AL\n" +
                            "Gedung AL digunakan oleh mahasiswa untuk laboratorium broadcasting.";
                        break;

                    case "AM":
                        detailsText = "Gedung AM / Aula Pertamina\n" +
                            "Gedung AM atau sering disebut dengan Aula Pertamina adalah aula yang digunakan untuk kegiatan seminar, job fair, pameran, lomba, dan kegiatan kampus lainya.\n" +
                            "Aula ini cukup luas, dan dilengkapi dengan AC, kamar mandi, dan proyektor. Aula yang pembangunannya didanai oleh Pertamina ini juga melayani masyarakat umum.";
                        break;

                    case "AN":
                        detailsText = "Gedung AN\n" +
                            "Gedung AN merupakan gedung tempat menyimpan genset dan gardu distribusi.\n" +
                            "Dimana ketika terjadi pemadaman listrik, genset akan dinyalakan di gedung ini.";
                        break;

                    case "AO":
                        detailsText = "Gedung AO\n" +
                            "Gedung AO merupakan gedung perkulian yang digunakan oleh mahasiswa jurusan Teknik Kimia.\n" +
                            "Di gedung ini dilengkapi dengan ruang kelas, laboratorium komputer, auditorium, dan ruang baca.";
                        break;

                    case "AP":
                        detailsText = "Gedung AP / Lab. Biodiesel\n" +
                            "Gedung AP berada di belakang gedung AO, sehingga jarang mahasiswa yang mengetahui digunakan untuk apa gedung ini.\n" +
                            "Laboratorium biodiesel digunakan untuk penelitian bagi mahasiswa teknik kimia mengenai pembuatan bahan bakar nabati yang dibuat dari minyak nabati.";
                        break;

                    case "AQ":
                        detailsText = "Gedung AQ / Lab. Jurusan Teknik Kimia\n" +
                            "Gegung AQ merupakan laboratorium bagi mahasiswa jurusan teknik kimia, beberapa laboratorium tersebut antara lain lab. Kimia dasar, lab. Kimia terapan, lab. Analisa instrumental, lab. Bioproses, lab. Pengolahan limbah, dan masih ada laboratium lainnya.\n" +
                            "Gedung ini juga sudah dilengkapi dengan lift agar lebih cepat sampai ke lantai atas gedung.";
                        break;

                    case "AR":
                        detailsText = "Gedung AR / Poliklinik\n" +
                            "Poliklinik ini, digunakan oleh mahasiswa atau karyawan Polinema agar dapat melakukan pemeriksaan kesehatan pada jam kerja.\n" +
                            "Dengan menggunakan KTM / Kartu pegawai, seluruh pihak Polinema dapat melakukan pengobatan gratis.\n" +
                            "Diharapkan dengan adanya poliklinik ini, kesehatan karyawan dan mahasiswa akan lebih terjaga.";
                        break;

                    case "AS":
                        detailsText = "Gedung AS\n" +
                            "Gedung digunakan sebagai garasi dan tempat OKI (Organisasi Kemahasiswaan Intra) Polinema.\n" +
                            "Lantai dasar gedung AS digunakan sebagai garasi bus Polinema, sedangkan lantai 2 menjadi berkumpul bagi mahasiswa yang tergabung dalam UKM (Unit Kegiatan Mahasiswa) dan HMJ (Himpunan Mahasiswa Jurusan).\n" +
                            "Dengan adanya gedung ini, diharapkan dapat meningkatkan produktifitas semua organisasi.";
                        break;

                    case "AT":
                        detailsText = "Gedung AT / UPT Percetakan\n" +
                            "Gedung AT merupakan sarana bagi UPT percetakan yang melayani bidang produksi percetakan dan penerbitan dilingkungan Polinema yang pada aktifitasnya erat berhubungan dengan pembuatan dan penerbitan panduan, berita, buku ajar, laporan akademis, penyediaan media cetak untuk pendidikan serta penelitian.";
                        break;

                    case "AU":
                        detailsText = "Gedung AU / Gedung Arsip\n" +
                            "Gedung AU atau yang lebih dikenal dengan gedung arsip adalah gedung untuk tempat penyimpanan berkas-berkas, surat penting, dan buku-buku dari UPT Percetakan Polinema.\n" +
                            "Mahasiswa mengambil buku yang mereka beli dari UPT Percetakan di gedung ini.";
                        break;

                    case "AV":
                        detailsText = "Gedung AV / Graha Teater\n" +
                            "Graha teater berada di belakang gedung AA. Tempat ini sering digunakan untuk berbagai kegiatan mahasiswa pertunjukan seni seperti teater, band, dance, tari tradisional.\n" +
                            "Selain pertunjukan seni, ada juga kegiatan lain seperti malam keakraban, bazaar dan lomba-lomba.";
                        break;

                    case "AW":
                        detailsText = "Gedung AW\n" +
                            "Gedung AW berada di dekat gerbang keluar Polinema, gedung ini sebagai pusat informasi.\n" +
                            "Mahasiswa bisa mendapatkan banyak informasi mengenai beasiswa, lomba-lomba di luar Polinema, dan informasi penting lainnya di gedung ini.";
                        break;
                    default:
                        detailsText = "Kosong";
                        break;
                }
                showDetail(detailsText);
            }
        }

        if (Input.GetKeyDown("escape"))
        {
            showHideDetail();
        }
    }

    public void showHideDetail()
    {
        if (isShowing == false)
        {
            scrollArea.gameObject.SetActive(true);
            isShowing = true;
        }
        else
        {
            scrollArea.gameObject.SetActive(false);
            isShowing = false;
        }
    }

    public void showDetail(string detailsText)
    {
        try
        {
            infoText.text = detailsText;
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("myLight was not set in the inspector");
        }
        scrollArea.gameObject.SetActive(true);
        isShowing = true;
    }

    public void hideDetail()
    {
        scrollArea.gameObject.SetActive(false);
        isShowing = false;
    }
}
