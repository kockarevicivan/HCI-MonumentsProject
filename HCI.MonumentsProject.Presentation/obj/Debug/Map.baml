   M S B A M L   `   `   `  ����\  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles+HCI.MonumentsProject.Presentation.HelpFiles  5   	   U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  5   	   +    %HCI.MonumentsProject.Presentation.Map   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gl9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles     5   	   Alocal/clr-namespace:HCI.MonumentsProject.Presentation     5   	     � Title$	  Map��5	   	   $	��509��6   $	��850��6"    � 
ResizeMode$ NoResize=�6.   >   8HCI.MonumentsProject.Presentation.HelpFiles.HelpProvider   HelpKey$ index��6D    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ 	mapCanvas��5       J� 	AllowDrop . $
��Left=�6�   $	��451��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��655��6  �� 5   
   -   5         ��Name$ listView��5      $��1��6G   $
��Left=�6W   $	��416��6r   $��	10,10,0,0q�6   $	��Top=�6�   $	��149��6�   ��6%   �� *	Monuments+	 �� View	 5      �� 5      .P�5      �� 
 �� Width$	
 149��6%   $��
Spomenici:��61    �� DisplayMemberBinding 6E   �� *Name+5      ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        5      5      �� 5    
   -   5         ��Name$ button��5       $��Nazad��6!   $��1��61   $
��Left=�6A   $��
10,431,0,0q�6\   $	��Top=�6p   $	��149��6�   $��30��6�   6�   5"      5#      