using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingSelect : MonoBehaviour {

    public GameObject scrollArea;
    public Text infoText;
    private bool isShowing;
    private string detailsText;

    // Use this for initialization
    void Start () {
        isShowing = false;
        scrollArea.gameObject.SetActive(isShowing);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name + " Clicked!");

                if (hit.transform.name == "Siti")
                {
                    detailsText = "Gedung Sipil Teknik Informatika\n" +
                        "Gedung ini memiliki 8 lantai dan dilengkapi dengan lift untuk mempercepat akses ke semua lantai.\n" +
                        "Lantai 1 sampai 6 digunakan oleh mahasiswa jurusan Teknik Sipil, sedangkan lantai 7 dan 8 digunakan " +
                        "untuk mahasiswa jurusan Teknik Informatika.\n" +
                        "Di gedung ini khususnya lantai 7 terdapat laboratorium dengan jumlah komputer yang memadai dan " +
                        "ruang kelas yang dilengkapi dengan fasilitas seperti AC, proyektor, papan tulis, meja, kursi. " +
                        "Selain itu di lantai 7 juga ada kantin yang menjual makanan ringan dan kue.";
                }
                else if (hit.transform.name == "Masjid")
                {
                    detailsText = "Masjid Raya An-Nur\n" +
                        "Masjid Raya An-Nur berada dekat dengan pintu masuk Polinema, sehingga posisinya " +
                        "mudah dijangkau juga oleh masyarakat umum.\n" +
                        "Masjid ini luas dan memiliki 3 lantai, namun yang bisa digunakan hanya lantai 1 saja " +
                        "karena masih dalam proses pembangunan.\n" +
                        "Setelah ini akan sering digunakan untuk acara seperti " +
                        "syiar islam, pengajian, istighosah, shalat jumat, dan kegiatan kerohanian lainnya.";
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
        infoText.text = detailsText;
        scrollArea.gameObject.SetActive(true);
        isShowing = true;
    }

    public void hideDetail()
    {
        scrollArea.gameObject.SetActive(false);
        isShowing = false;
    }
}
