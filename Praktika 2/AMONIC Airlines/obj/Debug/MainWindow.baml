   M S B A M L   `   `   `  ����J  FAMONIC Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AMONIC_AirlinesAMONIC_Airlines  5   	        AMONIC_Airlines.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AMONIC_Airlines     5   	     � Title$  Manage Flight Schedules��5   	   $	��720��6)   $
��1280��66    � 
ResizeMode$ NoResize=�6C    � WindowStartupLocation$ CenterScreen=�6Y   .��5	      � .+�5
   
   �� $
��Left=�6   $��
258,28,0,0q�6/   $
��Wrap=�6C   $��	Filter by��6W   $	��Top=�6h   
������� J� OpacityMask
 �����$��49��6�   $��Tex Gyre Adventor)�6�   �� 5   
   $
��Wrap=�6   $
��From��6(   $��
336,52,0,0q�64   $��19��6H   $	��Top=�6T   $
��Left=�6l   $��32��6�   $��Tex Gyre Adventor)�6�   �� 5   
   -   5         ��Name$ From_CB��5       �� DisplayMemberPath$ IATACode��6$   $
��Left=�6A   $��
374,51,0,0q�6\   $	��Top=�6p   $	��120��6�   $��Tex Gyre Adventor)�6�   �� 5   
   $
��Wrap=�6   $��To��6(   $��
525,52,0,0q�62   $��19��6F   $	��Top=�6R   $
��Left=�6j   $��29��6�   $��Tex Gyre Adventor)�6�   �� 5   
   -   5        $ To_CB��5      $ IATACode��6"   $
��Left=�6?   $��
559,49,0,0q�6Z   $	��Top=�6n   $	��120��6�   $��Tex Gyre Adventor)�6�   �� 5   
   $
��Wrap=�6   $��Sort by��6(   $��
723,54,0,0q�67   $��19��6K   $	��Top=�6W   $
��Left=�6o   $��54��6�   $��Tex Gyre Adventor)�6�   �� 5   
   -   5        $ 	SortBy_CB��5      $
��Left=�6&   $��
782,53,0,0q�6A   $	��Top=�6U   $	��120��6m   $��Tex Gyre Adventor)�6y   .@�5      �� $��	Date-time��6    �� 
IsSelected . 6/   �� 5      $��Price��6   �� 5      $��	Confirmed��6   5      �� 5   
   $
��Left=�6   $��310,111,0,0q�6/   $
��Wrap=�6D   $��Outbound��6X   $	��Top=�6h   $��65��6�   $��Tex Gyre Adventor)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Outbound_DP��5      $
��Left=�6*   $��375,110,0,0q�6E   $	��Top=�6Z   $	��120��6r   $��Tex Gyre Adventor)�6~   �� 5   
   $
��Left=�6   $��518,115,0,0q�6/   $
��Wrap=�6D   $��Flight Number��6X   $	��Top=�6m   $��82��6�   $��Tex Gyre Adventor)�6�   �� 5   
   -   5        $ FLightNumber_CB��5      $ FlightNumber��6,   $��Center=�6M   $��	0,114,0,0q�6j   $	��Top=�6}   $��74��6�   $��Tex Gyre Adventor)�6�   �� 5   
   -   5        $��Apply��5      $
��Left=�63   $��782,111,0,0q�6N   $	��Top=�6c   $	��120��6{   $��Tex Gyre Adventor)�6�   $��25��6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGrid��5      $��
80,183,0,0q�6"   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $	��405��6d   $	��Top=�6q   $
��Left=�6�   $
��1114��6�   $��Tex Gyre Adventor)�6�   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5       �� Binding 6&   �� *	Confirmed+ �� Value	 False6D   .a�5      ��  �� Property � �� �� Value
 �  ��6;   5       5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Date+ �� StringFormat$ {0:dd.}{0:MM.}{0:yyyy}��6u     5&      $
 Time��6%   $ * 6L    63   �� *Time+6L     5'      $
 From��6%   $ * 6`    63   �� *Routes.Airports.IATACode+6`     5(      $ To��6%   $ * 6_    61   �� *Routes.Airports1.IATACode+6_     5)      $ Flight number��6%   $ * 6]    6<   �� *FlightNumber+6]     5*      $ Aircraft��6%   $ * 6Z    67   �� *Aircrafts.Name+6Z     5+      $ Economy price��6%   $ * 6o    6<   �� *EconomyPrice+$	 0.$��6o     5,      $ Business price��6%   $ * 6p    6=   �� *EconomyPrice+$	 0.$��6p     5-      $ First class price��6%   $ * 6@   5/      �� 50   
   -   5        $��Cancel Flight��50      $
��Left=�6<   $��
80,630,0,0q�6W   $	��Top=�6k   $	��122��6�   $��Tex Gyre Adventor)�6�   $��32��6�   
�������6�   �� 51   
   -	   5        $��Edit Flight��51      $
��Left=�68   $��258,630,0,0q�6S   $	��Top=�6h   $	��125��6�   $��Tex Gyre Adventor)�6�   $��32��6�   
�������6�   �� 52   
   -
   5        $��Import Changes��52      $
��Left=�6*   $��1080,626,0,0q�6E   $	��Top=�6[   $	��114��6s   $��Tex Gyre Adventor)�6�   $��33��6�   
�������6�   53      54      