using Autofac;
using Simul.Engine;
using Simul.Engine.Rendering;
using Simul.World;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Simul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IContainer _container;
        private Runner _runner;

        public MainWindow()
        {
            InitializeComponent();

            BootstrapContainer();

            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var mcp = _container.Resolve<IMainCanvasProvider>();
            mcp.Register(MainCanvas);

            var wsp = _container.Resolve<IWorldSettingsProvider>();
            var ws = new WorldSettings() { Size = new Vector2(400, 200) };
            wsp.Register(ws);

            Task.Run(() =>
            {
                var worldCenter = new Transform();
                worldCenter.Position.X = ws.SizeDiv2.X;
                worldCenter.Position.Y = ws.SizeDiv2.Y;

                var rootComponent = new Component();
                rootComponent.Transform.Position.Set(ws.SizeDiv2);
                rootComponent.AppendBehavior(_container.Resolve<SimulatorRoot>());
                rootComponent.AppendBehavior(new FrameRenderer(ws.Size.X, ws.Size.Y, mcp));

                _runner = new Runner(_container.Resolve<IMainCanvasProvider>());
                _runner.Run(rootComponent);
            });
        }

        private void MainWindow_Closed(object sender, System.EventArgs e)
        {
            _runner.Stop();
        }

        private void BootstrapContainer()
        {
            var cb = new ContainerBuilder();

            cb
                .RegisterAssemblyTypes(typeof(MainWindow).Assembly)
                .AssignableTo<IBehavior>()
                .AsSelf();

            cb.RegisterAssemblyTypes(typeof(MainWindow).Assembly)
                .AsImplementedInterfaces();

            _container = cb.Build();
        }

        private int _clickCounter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _clickCounter++;
            //var button = sender as Button;
            //button.Content = $"Clicked {_clickCounter}";
            FirstTextBox.Text = $"Clicked {_clickCounter}";
        }
    }
}
