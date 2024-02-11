namespace MauiAppEspiralCuadrado
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            
            InitializeComponent();
            
        }

        private void Vueltas_SliderChanged(object sender, ValueChangedEventArgs e)
        {
            
            if(canvas!=null)
            {
                canvas.Drawable = new CanvasDrawable((int)e.NewValue);
                canvas.Invalidate();
            }
            
        }

       
    }

    internal class CanvasDrawable : IDrawable
    {
        public CanvasDrawable() { }

        private int _vueltas = 0;

        public CanvasDrawable(int vueltas)
        {
            _vueltas = vueltas;
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if(_vueltas>=0)
            {
                var centroX = dirtyRect.Width / 2;
                var centroY = dirtyRect.Height / 2;

                canvas.StrokeSize = 5;
                canvas.StrokeColor = Colors.Blue;
                canvas.StrokeLineJoin = LineJoin.Round;

                PathF linea = new PathF();
                //Centrar
                linea.MoveTo(centroX, centroY);
                //Fin Centrar

                int paso = 10;

                for (int i = 0; i < _vueltas; i++)
                {
                    //Derecha
                    linea.LineTo(centroX + 10 + (paso) * i, centroY + (paso) * i);
                    //Fin Derecha



                    //Arriba
                    linea.LineTo(centroX + 10 + (paso) * i, centroY - 10 - (paso) * i);
                    //Fin Arriba


                    //Izquierda
                    linea.LineTo(centroX - 10 - (paso) * i, centroY - 10 - (paso) * i);
                    //Fin Izquierda


                    //Abajo
                    linea.LineTo(centroX - 10 - (paso) * i, centroY + 10 + (paso) * i);
                    //Fin Abajo


                    //Derecha
                    linea.LineTo(centroX + 10 + (paso) * i, centroY + 10 + (paso) * i);
                    //Fin Derecha
                   
                }




                canvas.DrawPath(linea);
            }
            

        }
    }

}
