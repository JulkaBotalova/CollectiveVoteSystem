   M S B A M L   `   `   `  ����I  ECollectiveVote, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CollectiveVote.VoteCollectiveVote.Vote  5   	   (    "CollectiveVote.Forms.CondorcetForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CollectiveVote.Vote     5   	     � Title$  	Condorcet��5   	   $	��412��6   $	��416��6(   .��5	      � $��	0,0,-8,17q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $?��9Введите количество голосующих:��6   $
��Left=�6H   $��	23,22,0,0q�6c   $	��Top=�6v   �� 5   
   -   5         ��Name$ 
QuantityTB��5      $
��Left=�6&   $��23��6A   $��
223,26,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ label1��5      $g��aВведите в ячейки приоритет каждому кандидату от 1 до 3��6    $
��Left=�6a   $��	10,78,0,0q�6|   $	��Top=�6�   �� 5   
   -   5        $ label2��5      $��Египет��6    $
��Left=�61   $��121,123,0,0q�6L   $	��Top=�6a   �� 5   
   -   5        $ label3��5      $��Крым��6    $
��Left=�6/   $��121,166,0,0q�6J   $	��Top=�6_   �� 5   
   -   5        $ label4��5      $��Греция��6    $
��Left=�61   $��121,209,0,0q�6L   $	��Top=�6a   �� 5   
   -   5        $ TBEgypt��5      $
��Left=�6#   $��23��6>   $��197,126,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $��21��6�   �� 5   
   -   5        $ TBCrimea��5      $
��Left=�6$   $��23��6?   $��197,170,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $��21��6�   �� 5   
   -	   5        $ TBGreece��5      $
��Left=�6$   $��23��6?   $��197,213,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $��21��6�   �� 5   
   -
   5         ��Name$ NextB��5      $��Следующий��6    $
��Left=�64   $��
75,256,0,0q�6O   $	��Top=�6c   $	��191��6{   $��34��6�   6�   �� 5   
   -   5        $ WinnerB��5      $%��Явный победитель��6"   $
��Left=�6=   $��
23,334,0,0q�6X   $	��Top=�6l   $	��123��6�   6�   �� 5   
   -   5        $ KoplandB��5      $��Копленда��6#   $
��Left=�66   $��191,334,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ SimpsonB��5      $��Симпосона��6#   $
��Left=�67   $��299,334,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $ label5��5      $"��Выберите метод ��6    $
��Left=�6:   $��
23,303,0,0q�6U   $	��Top=�6i   5      5      