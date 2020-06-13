import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'tangens'

def tanFunction(sender, e):
    frm = sender.Tag
    frm.tbResult.Text = str(math.tan(float(frm.tbA.Text)))

def AddFunction(frm):
    operation = ToolStripMenuItem(Text='Tangens', Name='runTan', Size=Size(130, 25))
    operation.Tag = frm
    operation.Click += tanFunction
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(operation)