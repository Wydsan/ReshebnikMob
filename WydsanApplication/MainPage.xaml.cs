using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace WydsanApplication
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTopicSelected(object sender, EventArgs e)
        {
            // Обработка выбора темы
            // Можно добавить логику для отображения соответствующих формул
        }

        private void OnFormulaSelected(object sender, EventArgs e)
        {
            // Обработка выбора формулы
            // Можно добавить логику для отображения соответствующих полей ввода
        }

        private void OnSolveClicked(object sender, EventArgs e)
        {
            double mass, acceleration, force;

            bool isMassValid = double.TryParse(massEntry.Text, out mass);
            bool isAccelerationValid = double.TryParse(accelerationEntry.Text, out acceleration);
            bool isForceValid = double.TryParse(forceEntry.Text, out force);

            if (!isMassValid && !isAccelerationValid && !isForceValid)
            {
                resultLabel.Text = "Введите хотя бы одно значение.";
                return;
            }

        
            if (isMassValid && isAccelerationValid)
            {
                // Вычисляем силу
                force = mass* acceleration;
                resultLabel.Text = $"Сила F = {force}";
            }
            else if (isMassValid && isForceValid)
            {
                // Вычисляем ускорение
                acceleration = force / mass;
                resultLabel.Text = $"Ускорение a = {acceleration}";
            }
            else if (isForceValid && isAccelerationValid)
            {
                // Вычисляем массу
                mass = force / acceleration;
                resultLabel.Text = $"Масса m = {mass}";
            }
            else
            {
                resultLabel.Text = "Недостаточно данных для вычисления.";
            }
        }
    }
}

