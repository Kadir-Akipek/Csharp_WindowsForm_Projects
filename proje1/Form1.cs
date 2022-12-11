namespace proje1
{
    public partial class menu_projesec : Form
    {
        public menu_projesec()
        {
            InitializeComponent();
        }

        private void btn_hesapmakinesi_Click(object sender, EventArgs e)
        {
            form_hesapmakinesi yeni = new form_hesapmakinesi();
            //Form oluþturdum ve formu yeni adlý deðiþkene atadým
            yeni.Show();
            //Show metodu ile formu kullanýcýya gösterdim
            this.Hide();
            //Form 2 açýlýnca form 1 i sakladým
        }

        private void btn_notdefteri_Click(object sender, EventArgs e)
        {
            form_notdefteri yeni1 = new form_notdefteri();
            //Form oluþturdum ve formu yeni1 adlý deðiþkene atadým
            yeni1.Show();
            //Show metodu ile formu kullanýcýya gösterdim
            this.Hide();
            //Form 3 açýlýnca form 1 i sakladým
        }

        private void btn_askerdagitim_Click(object sender, EventArgs e)
        {
            form_askerdagitim yeni2 = new form_askerdagitim();
            //Form oluþturdum ve formu yeni2 adlý deðiþkene atadým
            yeni2.Show();
            this.Hide();
            //Form 4 açýlýnca form 1 i sakladým.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_buyukkucuk_uyum yeni3 = new form_buyukkucuk_uyum();
            //Form oluþturdum ve formu yeni3 adlý deðiþkene atadým
            yeni3.Show();
            this.Hide();
            //Form 5 açýlýnca form 1 i sakladým.
        }

        private void btn_poker_Click(object sender, EventArgs e)
        {
            form_poker yeni5 = new form_poker();
            //Form oluþturdum ve formu yeni5 adlý deðiþkene atadým
            yeni5.Show();
            this.Hide();
            //Form 7 açýlýnca form 1 i sakladým
        }

        private void btn_slotmakine_Click(object sender, EventArgs e)
        {
            form_slotmakine yeni6 = new form_slotmakine();
            //Form oluþturdum ve formu yeni6 adlý deðiþkene atadým
            yeni6.Show();
            this.Hide();
            //Form 8 açýlýnca form 1 i sakladým
        }

        private void btn_pckapa_Click(object sender, EventArgs e)
        {
            Form6 yeni7 = new Form6();
            //Form oluþturdum ve formu yeni7 adlý deðiþkene atadým
            yeni7.Show();
            this.Hide();
            //Form 6 açýlýnca form 1 i sakladým
        }

        private void btn_satranc_Click(object sender, EventArgs e)
        {
            Form9 yeni8 = new Form9();
            //Form oluþturdum ve formu yeni8 adlý deðiþkene atadým
            yeni8.Show();
            this.Hide();
            //Form 9 açýlýnca form 1 i sakladým
        }
    }
}