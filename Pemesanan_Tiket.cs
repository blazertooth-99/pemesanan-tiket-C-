using System;

public class PemesananTiket
{
	public int harga;
	public int jumlahSeat;
	public static void Main()
	{	
		Console.WriteLine("		PEMESANAN TIKET TRANSPORTASI");
		Console.WriteLine("=====================================");
		Console.WriteLine("	PRODUK PEMESANAN TIKET TRANSPORTASI");
		Console.WriteLine("=====================================");
		Console.WriteLine("		A. PESAWAT B. KERETA API 	");
		Console.WriteLine("										");
		Console.WriteLine("Note: Untuk pemesanan dengan jumlah >5 maka diskon 5%");
		Console.WriteLine("=====================================");
		Console.WriteLine("	Silahkan Pilih Opsi Pemesanan");
		pesanTiket pesantiket = new pesanTiket();
		pesantiket.pesan();
		if (pesantiket.jenisTiket=="A"){
		Pesawat pesawat= new Pesawat();
		pesawat.Tujuan();
		pesawat.harga= 1000000;
		Console.WriteLine("Harga Per Seat= "+pesawat.harga);
		Console.WriteLine("Masukkan Jumlah Seat :");
		pesawat.jumlahSeat= Convert.ToInt32(Console.ReadLine());
		Harga harga = new Harga();
		Console.WriteLine("Total Harga :"+harga.Total());
		
		}
		else if (pesantiket.jenisTiket=="B"){
		keretaApi keretaapi= new keretaApi();
		keretaapi.Tujuan();
		keretaapi.hKereta= 300000;
		Console.WriteLine("Harga Per Seat= "+keretaapi.hKereta);
		Console.Write("Masukkan Jumlah Seat :");
		keretaapi.jumlahSeat= Convert.ToInt32(Console.ReadLine());
		Harga harga = new Harga();
		Console.WriteLine("Total Harga :"+harga.Total());
		
	}
	Console.WriteLine("	Data Pelanggan");
	dataPelanggan datapelanggan = new dataPelanggan();
	datapelanggan.Nama();
	datapelanggan.nama = Convert.ToString(Console.ReadLine());
	ujk ujk =new ujk();
	ujk.Umur();
}

public class pesanTiket{
	public string jenisTiket;
	public string pesan(){
	jenisTiket=Console.ReadLine();
	return " ";
	}
}

public class Pesawat{
	public string tujuan;
	public int jumlahSeat;
	public int harga;
public void Tujuan(){
	Console.WriteLine("=============Pilih Tujuan=========");
	Console.WriteLine("A. Padang-Jakarta B.Jakarta-Padang");
	tujuan= Console.ReadLine();
	if (tujuan=="A"){
		Console.WriteLine("Tujuan: Padang-Jakarta");
	}
	else {
		Console.WriteLine("Tujuan: Jakarta-Padang");
	}	
	
}
}

public class keretaApi{
	public string tujuan;
	public int jumlahSeat;
	private int harga; 
	
public void Tujuan(){
	Console.WriteLine("=============Pilih Tujuan=========");
	Console.WriteLine("A. Gambir-Bandung B.Bandung-Gambir");
	tujuan= Console.ReadLine();
	if (tujuan=="A"){
		Console.WriteLine("Tujuan: Gambir-Bandung");
	}
	else {
		Console.WriteLine("Tujuan: Bandung-Gambir");
	}
}
public int hKereta{
	get { return harga; }
    set { harga = 300000; }
}
}

public class Harga : PemesananTiket{
	public double totalHarga;
	public int Total(){
	if (jumlahSeat>=3){
	totalHarga= 0.8*harga*jumlahSeat;}
	else{
	totalHarga= harga*jumlahSeat;}
	return 0;
		
	}
}

public class dataPelanggan{
	public string nama;
	protected int umur;
	protected string jenisKelamin;
public string Nama(){
	Console.WriteLine("Nama: ");
	return " ";
}	
}
public class ujk : dataPelanggan{
	public void Umur(){
	Console.Write("Umur :");
	umur= Convert.ToInt32(Console.ReadLine());
	Console.Write("Jenis Kelamin: ");
	jenisKelamin=Convert.ToString(Console.ReadLine());
	
	}
}
}
	




	
					  
	