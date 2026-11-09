Console.Write("Masukkan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukkan nama dokumen: ");
string namaDokumen = Console.ReadLine();

Console.Write("Masukkan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PERCETAKAN ===");
Console.WriteLine($"Nama Pelanggan: {namaPelanggan}");
Console.WriteLine($"Nama Dokumen: {namaDokumen}");
Console.WriteLine($"Jumlah Halaman: {jumlahHalaman}");
Console.WriteLine($"Harga Per Halaman: {hargaPerHalaman}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Biaya Administrasi: {biayaAdministrasi}");
Console.WriteLine($"Total Bayar: {totalBayar}");