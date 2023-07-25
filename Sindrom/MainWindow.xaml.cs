using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace Sindrom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z ;
        public List<object> listAl = new();


        public MainWindow()
        {
            InitializeComponent();

            a = new CoderMTK('a', "11000");
            b = new CoderMTK('b', "10011");
            c = new CoderMTK('c', "01110");
            d = new CoderMTK('d', "10010");
            e = new CoderMTK('e', "10000");
            f = new CoderMTK('f', "10110");
            g = new CoderMTK('g', "01011");
            h = new CoderMTK('h', "00101");
            i = new CoderMTK('i', "01100");
            j = new CoderMTK('j', "11010");
            k = new CoderMTK('k', "11110");
            l = new CoderMTK('l', "01001");
            m = new CoderMTK('m', "00111");
            n = new CoderMTK('n', "00110");
            o = new CoderMTK('o', "00011");
            p = new CoderMTK('p', "01101");
            q = new CoderMTK('q', "11101");
            r = new CoderMTK('r', "01010");
            s = new CoderMTK('s', "10100");
            t = new CoderMTK('t', "00001");
            u = new CoderMTK('u', "11100");
            v = new CoderMTK('v', "01111");
            w = new CoderMTK('w', "11001");
            x = new CoderMTK('x', "10111");
            y = new CoderMTK('y', "10101");
            z = new CoderMTK('z', "10001");

            listAl.Add(a);
            listAl.Add(b);
            listAl.Add(c);
            listAl.Add(d);
            listAl.Add(e);
            listAl.Add(f);
            listAl.Add(g);
            listAl.Add(h);
            listAl.Add(i);
            listAl.Add(j);
            listAl.Add(k);
            listAl.Add(l);
            listAl.Add(m);
            listAl.Add(n);
            listAl.Add(p);
            listAl.Add(q);
            listAl.Add(r);
            listAl.Add(s);
            listAl.Add(t);
            listAl.Add(u);
            listAl.Add(v);
            listAl.Add(w);
            listAl.Add(x);
            listAl.Add(y);
            listAl.Add(z);
        }

        public class CoderMTK 
        {
            public CoderMTK(char v1, string v2)
            {
                Symbhol = v1;
                Kod = v2;
            }

            char Symbhol { get; set; }
            string Kod { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sindrom_txt.Text != "" && combobox.TabIndex != -1) 
            {
                var sindromText = sindrom_txt.Text.ToLower();
                var sindromMassiveTxt = sindromText.ToList();
                var kodMassive = 
            }
        }
    }
}
