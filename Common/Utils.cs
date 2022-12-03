using System.Windows.Forms;

namespace EmployeesCrud.Common
{
    public static class Utils
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(
                    message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        public static void ShowInformation(string messsage)
        {
            MessageBox.Show(
                messsage,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
