   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:_404Project.VIews.Forms.UserFolder"_404Project.VIews.Forms.UserFolder  5   	   4    ._404Project.VIews.Forms.UserFolder.AddUserForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:_404Project.VIews.Forms.UserFolder     5   	     � Title$%  Добавление юзера��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;   .��5	      � .+�5
   
   �� -   5         ��Name$ LastNameBox��5
      $	��500��6'   $��35��6N   $
��Left=�6Z   $	��Top=�6u   $��
200,57,0,0q�6�   ��63   �� *
LastName+6�   �� 5   
   -   5        $ FirstNameBox��5      $	��500��6(   $��35��6P   $
��Left=�6\   $	��Top=�6w   $��200,107,0,0q�6�   ��64   �� *	FirstName+6�   �� 5   
   -   5        $ PhoneBox��5      $	��500��6$   $��35��6H   $
��Left=�6T   $	��Top=�6o   $��200,157,0,0q�6�   ��60   �� *Phone+6�   �� 5   
   -   5        $ PasswordBox��5      $	��500��6'   $��35��6N   $
��Left=�6Z   $	��Top=�6u   $��200,207,0,0q�6�   ��63   �� *
Password+6�   �� 5   
   -   5         ��Name$ 	RoleCombo��5       �� DisplayMemberPath$
 Name��6D   $	��500��6]    �� Text$
 Text��6i   $��35��6v   $
��Left=�6�   $	��Top=�6�   $��200,257,0,0q�6�    �� SelectedItem 6&   �� *Role+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	BirthDate��5       J� RenderTransformOrigin$ 0.5,0.5&�6I   $��201,310,0,0q�6i   $
��Left=�6~   $	��110��6�   $��27��6�   $	��Top=�6�      SelectedDate 6&   �� *	BirthDate+5      �� 5   
   $��Фамилия��6   $��14(�6#   	 �� TextAlignment$	 Center=�62   $	��200��6I   $
��Left=�6U   $	��Top=�6p   $��0,66,0,0q�6�   �� 5   
   $��Имя��6   $��14(�6   $	 Center=�6-   $	��200��6D   $
��Left=�6P   $	��Top=�6k   $��	0,116,0,0q�6�   �� 5   
   $��Телефон��6   $��14(�6#   $	 Center=�61   $	��200��6H   $
��Left=�6T   $	��Top=�6o   $��	0,166,0,0q�6�   �� 5   
   $��Пароль��6   $��14(�6"   $	 Center=�60   $	��200��6G   $
��Left=�6S   $	��Top=�6n   $��	0,216,0,0q�6�   �� 5   
   $��Роль��6   $��14(�6    $	 Center=�6.   $	��200��6E   $
��Left=�6Q   $	��Top=�6l   $��	0,266,0,0q�6�   �� 5   
   -   5        
 ��Name$
 SaveBtn��5      $��Right=�6"   $��Сохранить��6>   $��40��6R   $	��150��6^   $��Bottom=�6j   $��0,0,19.6,10q�6�   6�   �� 5   
   -   5        $
 	CancelBtn��5      $��Right=�6$   $��Закрыть��6@   $��40��6R   $	��150��6^   $��Bottom=�6j   $��0,0,174.6,10q�6�   6�   �� 5   
   $��Дата рождения��6   $��14(�6)   $	 Center=�67   $	��200��6N   $
��Left=�6Z   $	��Top=�6u   $��	0,312,0,0q�6�   �� 5   
   -	   5        $ 	GenderBox��5      $
 Name��6F   $	��255��6_   $
 Text��6k   $��35��6x   $
��Left=�6�   $	��Top=�6�   $��200,353,0,0q�6�    6&   �� *Gender+6�   �� 5   
   $��Пол��6   $��14(�6   $	 Center=�6-   $	��200��6D   $
��Left=�6P   $	��Top=�6k   $��	0,361,0,0q�6�   5      5      