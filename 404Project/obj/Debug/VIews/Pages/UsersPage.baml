   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_404Project.VIews.Pages_404Project.VIews.Pages  5      '    !_404Project.VIews.Pages.UsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:_404Project.VIews.Pages     5        N� Title$  Пользователи��5	      .��5      � 
�������.+�5   
   �� -   5         ��Name$ UsersListBox��5      $��44,55,37,28.6q�6(   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $%��https://64x.ru/images/man-5.png��6    $	��100��6I   $
��Fill=�6U   $	��100��6d   �� 5      $ Vertical=�6%   .+�5      �� ��6(   �� *	FirstName+ �� StringFormat$ Имя: {0}���� 5      ��6(   �� *
LastName+$ Фамилия: {0}���� 5      ��6(   �� *Phone+$ Телефон: {0}���� 5      ��6(   �� *
Password+$ Пароль: {0}���� 5      ��6(   �� *	Role.Name+$ Роль: {0}���� 5      ��6(   �� *	BirthDate+$&  Дата рождения: {0:d}��5      5      5      5      �� 5   
   -   5         ��Name$ AddBtn��5      $��Right=�6!   $��Добавить��6=   $��40��6P   $	��150��6\   $	��Top=�6h   $��	0,10,16,0q�6�   6�   �� 5    
   -   5        $ 	DeleteBtn��5       $��Right=�6$   $��Удалить��6@   $��40��6R   $	��150��6^   $	��Top=�6j   $��
0,10,171,0q�6�   6�   �� 5!   
   -   5        $ EditBtn��5!      $��Right=�6"   $ ��Редактировать��6>   $��40��6V   $	��150��6b   $	��Top=�6n   $��
0,10,326,0q�6�   6�   �� 5"   
   -   5         ��Name$ 	SearchBox��5"      $	��217��6%   $��35��6V   $
��Left=�6b   $	��Top=�6}   $��	82,10,0,0q�6�   �� 5#   
   $��Поиск ��6   $��14(�6"    �� TextAlignment$ Center=�60   $	��121��6G   $
��Left=�6S   $	��Top=�6n   $��	-9,20,0,0q�6�   5%      5&      