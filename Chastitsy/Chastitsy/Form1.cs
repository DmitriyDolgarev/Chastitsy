namespace Chastitsy
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        GravityPoint point1;
        GravityPoint point2;
        Counter point3;

        public Form1()
        {
            InitializeComponent();

            // прив€зал изображение
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и прив€зываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавл€ю в список emitters, чтобы он рендерилс€ и обновл€лс€

            point3 = new Counter
            {
                X = picDisplay.Width / 2 + 150,
                Y = picDisplay.Height / 2 + 100,
            };

            emitter.impactPoints.Add(point3);

            /*
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            // прив€зываем пол€ к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            */
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновл€ем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }

        // добавл€ем переменные дл€ хранени€ положени€ мыши
        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // это не трогаем
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            // а тут передаем положение мыши, в положение гравитона
            /*
            point2.X = e.X;
            point2.Y = e.Y;
            */
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}∞"; // добавил вывод значени€
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            //point1.Power = tbGraviton1.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            //point2.Power = tbGraviton2.Value;
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            label1.Text = $"{tbSpreading.Value}∞";
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            Counter counter = new Counter
            {
                X = e.X,
                Y = e.Y
            };

            emitter.impactPoints.Add(counter);
        }
    }
}
