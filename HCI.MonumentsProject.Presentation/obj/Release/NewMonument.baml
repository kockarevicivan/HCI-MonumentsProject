   M S B A M L   `   `   `  ���� \  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  3    -HCI.MonumentsProject.Presentation.NewMonument   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:HCI.MonumentsProject.Presentation     ?val/clr-namespace:HCI.MonumentsProject.Presentation       � Title$  Novi spomenik��$	��342��$��663.571��.���  � ColumnDefinitions �� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��* ��� $��1* ��� $��1* ��� $��1* ��� $
��1.5* �.+��� -    ��Name$ label��$
��Ime:��$
��Left=�$��	10,10,0,0q�$	��Top=��� -   $��textBox2��$��23��$
��Left=�$��	51,15,0,0q�$	��Top=�$	��135��.������  �� Path$	 Ime� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidationRules 1   +HCI.MonumentsProject.Presentation.NeSmeBroj  ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�.�� =� ErrorTemplate �� .R��  ��  �� �� $
��Auto �.+��� 	 ��Name$	 textBox��$��0��$��0���� $��1��$��0��
���  ������ *[0].ErrorContent+.���� -   $ 
label_Copy��$��Opis:��$
��Left=�$��	10,10,0,0q�$	��Top=�
 J� RenderTransformOrigin$
 0.969,4.308&�$��1���� -    ��Name$ textBox_Copy��$
��Left=�$��23��$��	47,13,0,0q�$��1�� �� TextWrapping$
 Wrap=�$��TextBox��$	��Top=�$	��139���� -    ��Name$ comboBox��$
��Left=�$��	47,14,0,0q�$��2��$	��Top=�$	��139���� -   $ label1��$
��Era:��$
��Left=�$��	13,10,0,0q�$��2��$	��Top=��� -   $ label2��$��Ikonica:��$
��Left=�$��	13,10,0,0q�$��3��$	��Top=��� -    ��Name$ button��$��Odaberi ikonicu��$
��Left=�$��	68,13,0,0q�$��3��$	��Top=�$	��118���� -	    ��Name$ checkBox��$��Arheološki obrađen��$��1��$
��Left=�$��	10,18,0,0q�$	��Top=�$
 0.239,0&��� -
   $ checkBox_Copy��$��Na UNESCO listi��$��1��$
��Left=�$��	10,18,0,0q�$	��Top=�$
 0.239,0&�$��1���� -   $ checkBox_Copy1��$��U naseljenoj oblasti��$��1��$
��Left=�$��	10,18,0,0q�$	��Top=�$
 0.239,0&�$��2���� -   $ label2_Copy��$��Turistički status:��$
��Left=�$��	10,10,0,0q�$��3��$	��Top=�$��1���� -   $ comboBox_Copy��$
��Left=�$��
104,13,0,0q�$��3��$	��Top=�$��82��$��1���� -   $ label_Copy1��$��Godišnji prihod:��$
��Left=�$��10,9,0,0q�$	��Top=�$��4���� -   $��textBox4��$��23��$
��Left=�$��	109,9,0,0q�$	��Top=�$	��132��$��4��.������ $ Prihod�$ PropertyChanged=� 2   ,HCI.MonumentsProject.Presentation.Validacija  $ RawProposedValue=�.�� �� .R��  ��  �� �� $
��Auto �.+��� $	 textBox��$��0��$��0���� $��1��$��0��
���  ������ *[0].ErrorContent+.���� -   $ label_Copy2��$��	Otkriven:��$
��Left=�$��10,9,0,0q�$	��Top=�$��4��$��1���� -   $ textBox_Copy2��$
��Left=�$��23��$��	73,13,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��113��$��4��$��1���� -   $ button1��$��Kreiraj��$��1��$
��Left=�$��	73,32,0,0q�$��5��$	��Top=�$	��113��$��30��