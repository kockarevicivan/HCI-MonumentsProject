   M S B A M L   `   `   `  ���� \  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  4    .HCI.MonumentsProject.Presentation.MonumentList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:HCI.MonumentsProject.Presentation       � Title$  Kompletna lista spomenika��$��454.555��$	��845��.���  � ColumnDefinitions ��  � RowDefinitions �� $��8* ��� $��1* �.+�&   System.Windows.Controls.DataGrid  -     Name$ monumentsGrid��$��10,10,10,10q�   
IsReadOnly .    AutoGenerateColumns .   � DataContext ��  �� Source$ 	monuments��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$		 Id:��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Id+  $
	 Ime:��
 �� *Name+  $	 Opis:��
 �� *Description+  $
	 Tip:��
 �� *MonumentType.Name+  $	 Ikonica:��
 �� *
IconPath+  $	 Arheološki obrađen:��
 �� *IsArchaeologicallyProcessed+  $	 Na listi UNESCO:��
 �� *IsOnUNESCOList+  $	 U naseljenom mestu:��
 �� *IsInPopulatedArea+  $	 Turistički status:��
 �� *TouristStatus+  $	 Godišnji prihod:��
 �� *
YearIncome+  $	 Datum otkrivanja:��
 �� *DateOfDiscovery+�� -    ��Name$ 
backButton��$��1��$��Nazad��$��762,0,10,10q�$��60���� -   $ removeButton��$��1��$��Izbriši��$��60��$��697,0,75,10q��� -   $ updateButton��$��1��$��Uredi��$��60��$��632,0,140,10q��� -   $ createButton��$��1��$��Kreiraj��$��60��$��567,0,205,10q�