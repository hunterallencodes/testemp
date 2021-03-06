# Generated by Django 3.2.4 on 2021-06-29 02:53

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('tasks', '0001_initial'),
        ('users', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='tasklist',
            name='employee',
            field=models.OneToOneField(on_delete=django.db.models.deletion.CASCADE, to='users.employee'),
        ),
        migrations.AddField(
            model_name='task',
            name='employee',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.DO_NOTHING, to='users.employee'),
        ),
        migrations.AddField(
            model_name='task',
            name='task_list',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.DO_NOTHING, to='tasks.tasklist'),
        ),
    ]
