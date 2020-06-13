import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *
clr.AddReference('System.Drawing')
from System.Drawing import Size
import math

name = 'square'

def squareFunction(sender, e):
    frm = sender.Tag
    frm.tbResult.Text = str((float(frm.tbA.Text)) * (float(frm.tbA.Text)))

def AddFunction(frm):
    operation = ToolStripMenuItem(Text='Square', Name='runSquare', Size=Size(130, 25))
    operation.Tag = frm
    operation.Click += squareFunction
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(operation)