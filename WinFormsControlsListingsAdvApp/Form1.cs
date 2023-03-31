namespace WinFormsControlsListingsAdvApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            //foreach(var item in checkedListBox1.CheckedItems)
            //{
            //    msg += item.ToString() + "\n";
            //}
            foreach (var i in checkedListBox1.CheckedIndices)
            {
                msg += checkedListBox1.Items[(int)i].ToString() + "\n";
            }

            MessageBox.Show(msg);
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            if (node is not null)
            {
                node.Expand();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            if (node is not null)
            {
                node.ExpandAll();
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            var node = treeView1.SelectedNode;
            if (node is not null)
            {
                node.Collapse();
            }
        }
    }
}