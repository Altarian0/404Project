   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_404Project.VIews.Pages_404Project.VIews.Pages  5      (    "_404Project.VIews.Pages.PlacesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:_404Project.VIews.Pages     5        N� Title$"  Местоположения��5	      .��5      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
PlacesGrid��5         AutoGenerateColumns .     
IsReadOnly . $��51,82,56,9.6q�6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Name+6Q     5      $ Широта��6%   $ * 6T    67   �� *
Latitude+6T     5      $ Долгота��6%   $ * 6V    68   �� *	Longitude+6V   5      �� 5   
   -   5         ��Name$ AddBtn��5      $��Right=�6!   $��Добавить��6=   $	��150��6P   $��	0,10,18,0q�6\   $��40��6�   $	��Top=�6�   �� 5   
   -   5        $ 	DeleteBtn��5      $��Right=�6$   $��Удалить��6@   $	��150��6R   $��
0,10,177,0q�6^   $��40��6�   $	��Top=�6�   �� 5   
   -   5        $ EditBtn��5      $��Right=�6"   $��Изменить��6>   $	��150��6Q   $��
0,10,337,0q�6]   $��40��6�   $	��Top=�6�   �� 5   
   -   5        	 ��Name$	 	SearchBox��5      $	��201��6%   $��35��6V   $
��Left=�6b   $	��Top=�6}   $��	89,16,0,0q�6�   �� 5   
   $��Поиск ��6   $��14(�6"   
 �� TextAlignment$
 Center=�60   $��82��6G   $
��Left=�6R   $	��Top=�6m   $��	16,20,0,0q�6�   5      5      